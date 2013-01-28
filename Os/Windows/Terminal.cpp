#include <OpenHome/Private/Terminal.h>

#include <conio.h>

namespace OpenHome {

TerminalOs::TerminalOs()
    : iHandle(0)
{
}

TChar TerminalOs::GetChar()
{
    return (_getch());
}

void TerminalOs::Print(const TChar* aFormat, ...)
{
    va_list args;
    va_start(args, aFormat);
    PrintVA(aFormat, args);
    va_end(args);
}

void TerminalOs::Print(const Brx& aBuffer)
{
    Log::Print(aBuffer);
}

void TerminalOs::PrintVA(const TChar* aFormat, va_list aArgs)
{
    Log::PrintVA(aFormat, aArgs);
}

} // namespace OpenHome
