#ifndef HEADER_SHELL
#define HEADER_SHELL

#include <OpenHome/OhNetTypes.h>
#include <OpenHome/Buffer.h>
#include <OpenHome/Exception.h>
#include <OpenHome/Private/Network.h>
#include <OpenHome/Private/Stream.h>
#include <OpenHome/Private/Thread.h>

#include <vector>
#include <map>

EXCEPTION(ShellCommandAlreadyRegistered);

namespace OpenHome {
namespace Net {

class IShellCommandHandler
{
public:
    virtual void HandleShellCommand(Brn aCommand, const std::vector<Brn>& aArgs, IWriter& aResponse) = 0;
};
    
class WriterShellResponse : public IWriter
{
    static const TUint kWriteBufferSizeBytes = 1024;
public:
    WriterShellResponse(IWriter& aWriter);
    ~WriterShellResponse();
public: // from IWriter
    void Write(TByte aValue);
    void Write(const Brx& aBuffer);
    void WriteFlush();
private:
    Sws<kWriteBufferSizeBytes>* iWriteBuffer;
};

class ShellSession : public SocketTcpSession
{
    static const TUint kMaxCommandBytes = 256;
    static const Brn kCmdExit;
public:
    ShellSession(IShellCommandHandler& aCommandHandler);
    virtual ~ShellSession();
private:
    void Log(const char* aMsg);
private: // from SocketTcpSession
    void Run();
private:
    IShellCommandHandler& iCommandHandler;
    Srs<kMaxCommandBytes>* iReadBuffer;
    WriterShellResponse* iWriterResponse;
    Semaphore iShutdownSem;
};
    
class Shell : private IShellCommandHandler
{
public:
    Shell();
    ~Shell();
    void AddCommandHandler(const TChar* aCommand, IShellCommandHandler& aHandler);
    void RemoveCommandHandler(const TChar* aCommand);
private: // from IShellCommandHandler
    void HandleShellCommand(Brn aCommand, const std::vector<Brn>& aArgs, IWriter& aResponse);
private:
    Mutex iLock;
    SocketTcpServer* iServer;
    typedef std::map<Brn, IShellCommandHandler*, BufferCmp> Map;
    Map iCommands;
};

} // namespace Net
} // namespace OpenHome

#endif // HEADER_SHELL