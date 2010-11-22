using System;
using System.Runtime.InteropServices;
using System.Text;
using Zapp;

namespace Zapp
{
    public interface ICpProxyUpnpOrgContentDirectory2
    {
        void SyncGetSearchCapabilities(out string aSearchCaps);
        void BeginGetSearchCapabilities(CpProxy.CallbackAsyncComplete aCallback);
        void EndGetSearchCapabilities(uint aAsyncHandle, out string aSearchCaps);
        void SyncGetSortCapabilities(out string aSortCaps);
        void BeginGetSortCapabilities(CpProxy.CallbackAsyncComplete aCallback);
        void EndGetSortCapabilities(uint aAsyncHandle, out string aSortCaps);
        void SyncGetSortExtensionCapabilities(out string aSortExtensionCaps);
        void BeginGetSortExtensionCapabilities(CpProxy.CallbackAsyncComplete aCallback);
        void EndGetSortExtensionCapabilities(uint aAsyncHandle, out string aSortExtensionCaps);
        void SyncGetFeatureList(out string aFeatureList);
        void BeginGetFeatureList(CpProxy.CallbackAsyncComplete aCallback);
        void EndGetFeatureList(uint aAsyncHandle, out string aFeatureList);
        void SyncGetSystemUpdateID(out uint aId);
        void BeginGetSystemUpdateID(CpProxy.CallbackAsyncComplete aCallback);
        void EndGetSystemUpdateID(uint aAsyncHandle, out uint aId);
        void SyncBrowse(string aObjectID, string aBrowseFlag, string aFilter, uint aStartingIndex, uint aRequestedCount, string aSortCriteria, out string aResult, out uint aNumberReturned, out uint aTotalMatches, out uint aUpdateID);
        void BeginBrowse(string aObjectID, string aBrowseFlag, string aFilter, uint aStartingIndex, uint aRequestedCount, string aSortCriteria, CpProxy.CallbackAsyncComplete aCallback);
        void EndBrowse(uint aAsyncHandle, out string aResult, out uint aNumberReturned, out uint aTotalMatches, out uint aUpdateID);
        void SyncSearch(string aContainerID, string aSearchCriteria, string aFilter, uint aStartingIndex, uint aRequestedCount, string aSortCriteria, out string aResult, out uint aNumberReturned, out uint aTotalMatches, out uint aUpdateID);
        void BeginSearch(string aContainerID, string aSearchCriteria, string aFilter, uint aStartingIndex, uint aRequestedCount, string aSortCriteria, CpProxy.CallbackAsyncComplete aCallback);
        void EndSearch(uint aAsyncHandle, out string aResult, out uint aNumberReturned, out uint aTotalMatches, out uint aUpdateID);
        void SyncCreateObject(string aContainerID, string aElements, out string aObjectID, out string aResult);
        void BeginCreateObject(string aContainerID, string aElements, CpProxy.CallbackAsyncComplete aCallback);
        void EndCreateObject(uint aAsyncHandle, out string aObjectID, out string aResult);
        void SyncDestroyObject(string aObjectID);
        void BeginDestroyObject(string aObjectID, CpProxy.CallbackAsyncComplete aCallback);
        void EndDestroyObject(uint aAsyncHandle);
        void SyncUpdateObject(string aObjectID, string aCurrentTagValue, string aNewTagValue);
        void BeginUpdateObject(string aObjectID, string aCurrentTagValue, string aNewTagValue, CpProxy.CallbackAsyncComplete aCallback);
        void EndUpdateObject(uint aAsyncHandle);
        void SyncMoveObject(string aObjectID, string aNewParentID, out string aNewObjectID);
        void BeginMoveObject(string aObjectID, string aNewParentID, CpProxy.CallbackAsyncComplete aCallback);
        void EndMoveObject(uint aAsyncHandle, out string aNewObjectID);
        void SyncImportResource(string aSourceURI, string aDestinationURI, out uint aTransferID);
        void BeginImportResource(string aSourceURI, string aDestinationURI, CpProxy.CallbackAsyncComplete aCallback);
        void EndImportResource(uint aAsyncHandle, out uint aTransferID);
        void SyncExportResource(string aSourceURI, string aDestinationURI, out uint aTransferID);
        void BeginExportResource(string aSourceURI, string aDestinationURI, CpProxy.CallbackAsyncComplete aCallback);
        void EndExportResource(uint aAsyncHandle, out uint aTransferID);
        void SyncDeleteResource(string aResourceURI);
        void BeginDeleteResource(string aResourceURI, CpProxy.CallbackAsyncComplete aCallback);
        void EndDeleteResource(uint aAsyncHandle);
        void SyncStopTransferResource(uint aTransferID);
        void BeginStopTransferResource(uint aTransferID, CpProxy.CallbackAsyncComplete aCallback);
        void EndStopTransferResource(uint aAsyncHandle);
        void SyncGetTransferProgress(uint aTransferID, out string aTransferStatus, out string aTransferLength, out string aTransferTotal);
        void BeginGetTransferProgress(uint aTransferID, CpProxy.CallbackAsyncComplete aCallback);
        void EndGetTransferProgress(uint aAsyncHandle, out string aTransferStatus, out string aTransferLength, out string aTransferTotal);
        void SyncCreateReference(string aContainerID, string aObjectID, out string aNewID);
        void BeginCreateReference(string aContainerID, string aObjectID, CpProxy.CallbackAsyncComplete aCallback);
        void EndCreateReference(uint aAsyncHandle, out string aNewID);

        void SetPropertySystemUpdateIDChanged(CpProxy.CallbackPropertyChanged aSystemUpdateIDChanged);
        void PropertySystemUpdateID(out uint aSystemUpdateID);
        void SetPropertyContainerUpdateIDsChanged(CpProxy.CallbackPropertyChanged aContainerUpdateIDsChanged);
        void PropertyContainerUpdateIDs(out string aContainerUpdateIDs);
        void SetPropertyTransferIDsChanged(CpProxy.CallbackPropertyChanged aTransferIDsChanged);
        void PropertyTransferIDs(out string aTransferIDs);
    }

    public class CpProxyUpnpOrgContentDirectory2 : CpProxy, IDisposable, ICpProxyUpnpOrgContentDirectory2
    {
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern uint CpProxyUpnpOrgContentDirectory2Create(uint aDeviceHandle);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern void CpProxyUpnpOrgContentDirectory2Destroy(uint aHandle);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2SyncGetSearchCapabilities(uint aHandle, char** aSearchCaps);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2BeginGetSearchCapabilities(uint aHandle, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe int CpProxyUpnpOrgContentDirectory2EndGetSearchCapabilities(uint aHandle, uint aAsync, char** aSearchCaps);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2SyncGetSortCapabilities(uint aHandle, char** aSortCaps);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2BeginGetSortCapabilities(uint aHandle, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe int CpProxyUpnpOrgContentDirectory2EndGetSortCapabilities(uint aHandle, uint aAsync, char** aSortCaps);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2SyncGetSortExtensionCapabilities(uint aHandle, char** aSortExtensionCaps);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2BeginGetSortExtensionCapabilities(uint aHandle, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe int CpProxyUpnpOrgContentDirectory2EndGetSortExtensionCapabilities(uint aHandle, uint aAsync, char** aSortExtensionCaps);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2SyncGetFeatureList(uint aHandle, char** aFeatureList);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2BeginGetFeatureList(uint aHandle, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe int CpProxyUpnpOrgContentDirectory2EndGetFeatureList(uint aHandle, uint aAsync, char** aFeatureList);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2SyncGetSystemUpdateID(uint aHandle, uint* aId);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2BeginGetSystemUpdateID(uint aHandle, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe int CpProxyUpnpOrgContentDirectory2EndGetSystemUpdateID(uint aHandle, uint aAsync, uint* aId);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2SyncBrowse(uint aHandle, char* aObjectID, char* aBrowseFlag, char* aFilter, uint aStartingIndex, uint aRequestedCount, char* aSortCriteria, char** aResult, uint* aNumberReturned, uint* aTotalMatches, uint* aUpdateID);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2BeginBrowse(uint aHandle, char* aObjectID, char* aBrowseFlag, char* aFilter, uint aStartingIndex, uint aRequestedCount, char* aSortCriteria, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe int CpProxyUpnpOrgContentDirectory2EndBrowse(uint aHandle, uint aAsync, char** aResult, uint* aNumberReturned, uint* aTotalMatches, uint* aUpdateID);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2SyncSearch(uint aHandle, char* aContainerID, char* aSearchCriteria, char* aFilter, uint aStartingIndex, uint aRequestedCount, char* aSortCriteria, char** aResult, uint* aNumberReturned, uint* aTotalMatches, uint* aUpdateID);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2BeginSearch(uint aHandle, char* aContainerID, char* aSearchCriteria, char* aFilter, uint aStartingIndex, uint aRequestedCount, char* aSortCriteria, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe int CpProxyUpnpOrgContentDirectory2EndSearch(uint aHandle, uint aAsync, char** aResult, uint* aNumberReturned, uint* aTotalMatches, uint* aUpdateID);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2SyncCreateObject(uint aHandle, char* aContainerID, char* aElements, char** aObjectID, char** aResult);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2BeginCreateObject(uint aHandle, char* aContainerID, char* aElements, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe int CpProxyUpnpOrgContentDirectory2EndCreateObject(uint aHandle, uint aAsync, char** aObjectID, char** aResult);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2SyncDestroyObject(uint aHandle, char* aObjectID);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2BeginDestroyObject(uint aHandle, char* aObjectID, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe int CpProxyUpnpOrgContentDirectory2EndDestroyObject(uint aHandle, uint aAsync);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2SyncUpdateObject(uint aHandle, char* aObjectID, char* aCurrentTagValue, char* aNewTagValue);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2BeginUpdateObject(uint aHandle, char* aObjectID, char* aCurrentTagValue, char* aNewTagValue, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe int CpProxyUpnpOrgContentDirectory2EndUpdateObject(uint aHandle, uint aAsync);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2SyncMoveObject(uint aHandle, char* aObjectID, char* aNewParentID, char** aNewObjectID);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2BeginMoveObject(uint aHandle, char* aObjectID, char* aNewParentID, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe int CpProxyUpnpOrgContentDirectory2EndMoveObject(uint aHandle, uint aAsync, char** aNewObjectID);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2SyncImportResource(uint aHandle, char* aSourceURI, char* aDestinationURI, uint* aTransferID);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2BeginImportResource(uint aHandle, char* aSourceURI, char* aDestinationURI, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe int CpProxyUpnpOrgContentDirectory2EndImportResource(uint aHandle, uint aAsync, uint* aTransferID);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2SyncExportResource(uint aHandle, char* aSourceURI, char* aDestinationURI, uint* aTransferID);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2BeginExportResource(uint aHandle, char* aSourceURI, char* aDestinationURI, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe int CpProxyUpnpOrgContentDirectory2EndExportResource(uint aHandle, uint aAsync, uint* aTransferID);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2SyncDeleteResource(uint aHandle, char* aResourceURI);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2BeginDeleteResource(uint aHandle, char* aResourceURI, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe int CpProxyUpnpOrgContentDirectory2EndDeleteResource(uint aHandle, uint aAsync);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2SyncStopTransferResource(uint aHandle, uint aTransferID);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2BeginStopTransferResource(uint aHandle, uint aTransferID, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe int CpProxyUpnpOrgContentDirectory2EndStopTransferResource(uint aHandle, uint aAsync);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2SyncGetTransferProgress(uint aHandle, uint aTransferID, char** aTransferStatus, char** aTransferLength, char** aTransferTotal);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2BeginGetTransferProgress(uint aHandle, uint aTransferID, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe int CpProxyUpnpOrgContentDirectory2EndGetTransferProgress(uint aHandle, uint aAsync, char** aTransferStatus, char** aTransferLength, char** aTransferTotal);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2SyncCreateReference(uint aHandle, char* aContainerID, char* aObjectID, char** aNewID);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2BeginCreateReference(uint aHandle, char* aContainerID, char* aObjectID, CallbackActionComplete aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe int CpProxyUpnpOrgContentDirectory2EndCreateReference(uint aHandle, uint aAsync, char** aNewID);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern void CpProxyUpnpOrgContentDirectory2SetPropertySystemUpdateIDChanged(uint aHandle, Callback aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern void CpProxyUpnpOrgContentDirectory2SetPropertyContainerUpdateIDsChanged(uint aHandle, Callback aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern void CpProxyUpnpOrgContentDirectory2SetPropertyTransferIDsChanged(uint aHandle, Callback aCallback, IntPtr aPtr);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2PropertySystemUpdateID(uint aHandle, uint* aSystemUpdateID);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2PropertyContainerUpdateIDs(uint aHandle, char** aContainerUpdateIDs);
        [DllImport("CpUpnpOrgContentDirectory2")]
        static extern unsafe void CpProxyUpnpOrgContentDirectory2PropertyTransferIDs(uint aHandle, char** aTransferIDs);
        [DllImport("ZappUpnp")]
        static extern unsafe void ZappFree(void* aPtr);

        private GCHandle iGch;
        private CallbackPropertyChanged iSystemUpdateIDChanged;
        private CallbackPropertyChanged iContainerUpdateIDsChanged;
        private CallbackPropertyChanged iTransferIDsChanged;
        private Callback iCallbackSystemUpdateIDChanged;
        private Callback iCallbackContainerUpdateIDsChanged;
        private Callback iCallbackTransferIDsChanged;

        public CpProxyUpnpOrgContentDirectory2(CpDevice aDevice)
        {
            iHandle = CpProxyUpnpOrgContentDirectory2Create(aDevice.Handle());
            iGch = GCHandle.Alloc(this);
        }

        public unsafe void SyncGetSearchCapabilities(out string aSearchCaps)
        {
			char* searchCaps;
			{
				CpProxyUpnpOrgContentDirectory2SyncGetSearchCapabilities(iHandle, &searchCaps);
			}
            aSearchCaps = Marshal.PtrToStringAnsi((IntPtr)searchCaps);
            ZappFree(searchCaps);
        }

        public unsafe void BeginGetSearchCapabilities(CallbackAsyncComplete aCallback)
        {
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgContentDirectory2BeginGetSearchCapabilities(iHandle, iActionComplete, ptr);
        }

        public unsafe void EndGetSearchCapabilities(uint aAsyncHandle, out string aSearchCaps)
        {
			char* searchCaps;
			{
				if (0 != CpProxyUpnpOrgContentDirectory2EndGetSearchCapabilities(iHandle, aAsyncHandle, &searchCaps))
				{
					throw(new ProxyError());
				}
			}
            aSearchCaps = Marshal.PtrToStringAnsi((IntPtr)searchCaps);
            ZappFree(searchCaps);
        }

        public unsafe void SyncGetSortCapabilities(out string aSortCaps)
        {
			char* sortCaps;
			{
				CpProxyUpnpOrgContentDirectory2SyncGetSortCapabilities(iHandle, &sortCaps);
			}
            aSortCaps = Marshal.PtrToStringAnsi((IntPtr)sortCaps);
            ZappFree(sortCaps);
        }

        public unsafe void BeginGetSortCapabilities(CallbackAsyncComplete aCallback)
        {
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgContentDirectory2BeginGetSortCapabilities(iHandle, iActionComplete, ptr);
        }

        public unsafe void EndGetSortCapabilities(uint aAsyncHandle, out string aSortCaps)
        {
			char* sortCaps;
			{
				if (0 != CpProxyUpnpOrgContentDirectory2EndGetSortCapabilities(iHandle, aAsyncHandle, &sortCaps))
				{
					throw(new ProxyError());
				}
			}
            aSortCaps = Marshal.PtrToStringAnsi((IntPtr)sortCaps);
            ZappFree(sortCaps);
        }

        public unsafe void SyncGetSortExtensionCapabilities(out string aSortExtensionCaps)
        {
			char* sortExtensionCaps;
			{
				CpProxyUpnpOrgContentDirectory2SyncGetSortExtensionCapabilities(iHandle, &sortExtensionCaps);
			}
            aSortExtensionCaps = Marshal.PtrToStringAnsi((IntPtr)sortExtensionCaps);
            ZappFree(sortExtensionCaps);
        }

        public unsafe void BeginGetSortExtensionCapabilities(CallbackAsyncComplete aCallback)
        {
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgContentDirectory2BeginGetSortExtensionCapabilities(iHandle, iActionComplete, ptr);
        }

        public unsafe void EndGetSortExtensionCapabilities(uint aAsyncHandle, out string aSortExtensionCaps)
        {
			char* sortExtensionCaps;
			{
				if (0 != CpProxyUpnpOrgContentDirectory2EndGetSortExtensionCapabilities(iHandle, aAsyncHandle, &sortExtensionCaps))
				{
					throw(new ProxyError());
				}
			}
            aSortExtensionCaps = Marshal.PtrToStringAnsi((IntPtr)sortExtensionCaps);
            ZappFree(sortExtensionCaps);
        }

        public unsafe void SyncGetFeatureList(out string aFeatureList)
        {
			char* featureList;
			{
				CpProxyUpnpOrgContentDirectory2SyncGetFeatureList(iHandle, &featureList);
			}
            aFeatureList = Marshal.PtrToStringAnsi((IntPtr)featureList);
            ZappFree(featureList);
        }

        public unsafe void BeginGetFeatureList(CallbackAsyncComplete aCallback)
        {
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgContentDirectory2BeginGetFeatureList(iHandle, iActionComplete, ptr);
        }

        public unsafe void EndGetFeatureList(uint aAsyncHandle, out string aFeatureList)
        {
			char* featureList;
			{
				if (0 != CpProxyUpnpOrgContentDirectory2EndGetFeatureList(iHandle, aAsyncHandle, &featureList))
				{
					throw(new ProxyError());
				}
			}
            aFeatureList = Marshal.PtrToStringAnsi((IntPtr)featureList);
            ZappFree(featureList);
        }

        public unsafe void SyncGetSystemUpdateID(out uint aId)
        {
			fixed (uint* id = &aId)
			{
				CpProxyUpnpOrgContentDirectory2SyncGetSystemUpdateID(iHandle, id);
			}
        }

        public unsafe void BeginGetSystemUpdateID(CallbackAsyncComplete aCallback)
        {
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgContentDirectory2BeginGetSystemUpdateID(iHandle, iActionComplete, ptr);
        }

        public unsafe void EndGetSystemUpdateID(uint aAsyncHandle, out uint aId)
        {
			fixed (uint* id = &aId)
			{
				if (0 != CpProxyUpnpOrgContentDirectory2EndGetSystemUpdateID(iHandle, aAsyncHandle, id))
				{
					throw(new ProxyError());
				}
			}
        }

        public unsafe void SyncBrowse(string aObjectID, string aBrowseFlag, string aFilter, uint aStartingIndex, uint aRequestedCount, string aSortCriteria, out string aResult, out uint aNumberReturned, out uint aTotalMatches, out uint aUpdateID)
        {
			char* objectID = (char*)Marshal.StringToHGlobalAnsi(aObjectID);
			char* browseFlag = (char*)Marshal.StringToHGlobalAnsi(aBrowseFlag);
			char* filter = (char*)Marshal.StringToHGlobalAnsi(aFilter);
			char* sortCriteria = (char*)Marshal.StringToHGlobalAnsi(aSortCriteria);
			char* result;
			fixed (uint* numberReturned = &aNumberReturned)
			fixed (uint* totalMatches = &aTotalMatches)
			fixed (uint* updateID = &aUpdateID)
			{
				CpProxyUpnpOrgContentDirectory2SyncBrowse(iHandle, objectID, browseFlag, filter, aStartingIndex, aRequestedCount, sortCriteria, &result, numberReturned, totalMatches, updateID);
			}
			Marshal.FreeHGlobal((IntPtr)objectID);
			Marshal.FreeHGlobal((IntPtr)browseFlag);
			Marshal.FreeHGlobal((IntPtr)filter);
			Marshal.FreeHGlobal((IntPtr)sortCriteria);
            aResult = Marshal.PtrToStringAnsi((IntPtr)result);
            ZappFree(result);
        }

        public unsafe void BeginBrowse(string aObjectID, string aBrowseFlag, string aFilter, uint aStartingIndex, uint aRequestedCount, string aSortCriteria, CallbackAsyncComplete aCallback)
        {
			char* objectID = (char*)Marshal.StringToHGlobalAnsi(aObjectID);
			char* browseFlag = (char*)Marshal.StringToHGlobalAnsi(aBrowseFlag);
			char* filter = (char*)Marshal.StringToHGlobalAnsi(aFilter);
			char* sortCriteria = (char*)Marshal.StringToHGlobalAnsi(aSortCriteria);
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgContentDirectory2BeginBrowse(iHandle, objectID, browseFlag, filter, aStartingIndex, aRequestedCount, sortCriteria, iActionComplete, ptr);
			Marshal.FreeHGlobal((IntPtr)objectID);
			Marshal.FreeHGlobal((IntPtr)browseFlag);
			Marshal.FreeHGlobal((IntPtr)filter);
			Marshal.FreeHGlobal((IntPtr)sortCriteria);
        }

        public unsafe void EndBrowse(uint aAsyncHandle, out string aResult, out uint aNumberReturned, out uint aTotalMatches, out uint aUpdateID)
        {
			char* result;
			fixed (uint* numberReturned = &aNumberReturned)
			fixed (uint* totalMatches = &aTotalMatches)
			fixed (uint* updateID = &aUpdateID)
			{
				if (0 != CpProxyUpnpOrgContentDirectory2EndBrowse(iHandle, aAsyncHandle, &result, numberReturned, totalMatches, updateID))
				{
					throw(new ProxyError());
				}
			}
            aResult = Marshal.PtrToStringAnsi((IntPtr)result);
            ZappFree(result);
        }

        public unsafe void SyncSearch(string aContainerID, string aSearchCriteria, string aFilter, uint aStartingIndex, uint aRequestedCount, string aSortCriteria, out string aResult, out uint aNumberReturned, out uint aTotalMatches, out uint aUpdateID)
        {
			char* containerID = (char*)Marshal.StringToHGlobalAnsi(aContainerID);
			char* searchCriteria = (char*)Marshal.StringToHGlobalAnsi(aSearchCriteria);
			char* filter = (char*)Marshal.StringToHGlobalAnsi(aFilter);
			char* sortCriteria = (char*)Marshal.StringToHGlobalAnsi(aSortCriteria);
			char* result;
			fixed (uint* numberReturned = &aNumberReturned)
			fixed (uint* totalMatches = &aTotalMatches)
			fixed (uint* updateID = &aUpdateID)
			{
				CpProxyUpnpOrgContentDirectory2SyncSearch(iHandle, containerID, searchCriteria, filter, aStartingIndex, aRequestedCount, sortCriteria, &result, numberReturned, totalMatches, updateID);
			}
			Marshal.FreeHGlobal((IntPtr)containerID);
			Marshal.FreeHGlobal((IntPtr)searchCriteria);
			Marshal.FreeHGlobal((IntPtr)filter);
			Marshal.FreeHGlobal((IntPtr)sortCriteria);
            aResult = Marshal.PtrToStringAnsi((IntPtr)result);
            ZappFree(result);
        }

        public unsafe void BeginSearch(string aContainerID, string aSearchCriteria, string aFilter, uint aStartingIndex, uint aRequestedCount, string aSortCriteria, CallbackAsyncComplete aCallback)
        {
			char* containerID = (char*)Marshal.StringToHGlobalAnsi(aContainerID);
			char* searchCriteria = (char*)Marshal.StringToHGlobalAnsi(aSearchCriteria);
			char* filter = (char*)Marshal.StringToHGlobalAnsi(aFilter);
			char* sortCriteria = (char*)Marshal.StringToHGlobalAnsi(aSortCriteria);
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgContentDirectory2BeginSearch(iHandle, containerID, searchCriteria, filter, aStartingIndex, aRequestedCount, sortCriteria, iActionComplete, ptr);
			Marshal.FreeHGlobal((IntPtr)containerID);
			Marshal.FreeHGlobal((IntPtr)searchCriteria);
			Marshal.FreeHGlobal((IntPtr)filter);
			Marshal.FreeHGlobal((IntPtr)sortCriteria);
        }

        public unsafe void EndSearch(uint aAsyncHandle, out string aResult, out uint aNumberReturned, out uint aTotalMatches, out uint aUpdateID)
        {
			char* result;
			fixed (uint* numberReturned = &aNumberReturned)
			fixed (uint* totalMatches = &aTotalMatches)
			fixed (uint* updateID = &aUpdateID)
			{
				if (0 != CpProxyUpnpOrgContentDirectory2EndSearch(iHandle, aAsyncHandle, &result, numberReturned, totalMatches, updateID))
				{
					throw(new ProxyError());
				}
			}
            aResult = Marshal.PtrToStringAnsi((IntPtr)result);
            ZappFree(result);
        }

        public unsafe void SyncCreateObject(string aContainerID, string aElements, out string aObjectID, out string aResult)
        {
			char* containerID = (char*)Marshal.StringToHGlobalAnsi(aContainerID);
			char* elements = (char*)Marshal.StringToHGlobalAnsi(aElements);
			char* objectID;
			char* result;
			{
				CpProxyUpnpOrgContentDirectory2SyncCreateObject(iHandle, containerID, elements, &objectID, &result);
			}
			Marshal.FreeHGlobal((IntPtr)containerID);
			Marshal.FreeHGlobal((IntPtr)elements);
            aObjectID = Marshal.PtrToStringAnsi((IntPtr)objectID);
            ZappFree(objectID);
            aResult = Marshal.PtrToStringAnsi((IntPtr)result);
            ZappFree(result);
        }

        public unsafe void BeginCreateObject(string aContainerID, string aElements, CallbackAsyncComplete aCallback)
        {
			char* containerID = (char*)Marshal.StringToHGlobalAnsi(aContainerID);
			char* elements = (char*)Marshal.StringToHGlobalAnsi(aElements);
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgContentDirectory2BeginCreateObject(iHandle, containerID, elements, iActionComplete, ptr);
			Marshal.FreeHGlobal((IntPtr)containerID);
			Marshal.FreeHGlobal((IntPtr)elements);
        }

        public unsafe void EndCreateObject(uint aAsyncHandle, out string aObjectID, out string aResult)
        {
			char* objectID;
			char* result;
			{
				if (0 != CpProxyUpnpOrgContentDirectory2EndCreateObject(iHandle, aAsyncHandle, &objectID, &result))
				{
					throw(new ProxyError());
				}
			}
            aObjectID = Marshal.PtrToStringAnsi((IntPtr)objectID);
            ZappFree(objectID);
            aResult = Marshal.PtrToStringAnsi((IntPtr)result);
            ZappFree(result);
        }

        public unsafe void SyncDestroyObject(string aObjectID)
        {
			char* objectID = (char*)Marshal.StringToHGlobalAnsi(aObjectID);
			{
				CpProxyUpnpOrgContentDirectory2SyncDestroyObject(iHandle, objectID);
			}
			Marshal.FreeHGlobal((IntPtr)objectID);
        }

        public unsafe void BeginDestroyObject(string aObjectID, CallbackAsyncComplete aCallback)
        {
			char* objectID = (char*)Marshal.StringToHGlobalAnsi(aObjectID);
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgContentDirectory2BeginDestroyObject(iHandle, objectID, iActionComplete, ptr);
			Marshal.FreeHGlobal((IntPtr)objectID);
        }

        public unsafe void EndDestroyObject(uint aAsyncHandle)
        {
			{
				if (0 != CpProxyUpnpOrgContentDirectory2EndDestroyObject(iHandle, aAsyncHandle))
				{
					throw(new ProxyError());
				}
			}
        }

        public unsafe void SyncUpdateObject(string aObjectID, string aCurrentTagValue, string aNewTagValue)
        {
			char* objectID = (char*)Marshal.StringToHGlobalAnsi(aObjectID);
			char* currentTagValue = (char*)Marshal.StringToHGlobalAnsi(aCurrentTagValue);
			char* newTagValue = (char*)Marshal.StringToHGlobalAnsi(aNewTagValue);
			{
				CpProxyUpnpOrgContentDirectory2SyncUpdateObject(iHandle, objectID, currentTagValue, newTagValue);
			}
			Marshal.FreeHGlobal((IntPtr)objectID);
			Marshal.FreeHGlobal((IntPtr)currentTagValue);
			Marshal.FreeHGlobal((IntPtr)newTagValue);
        }

        public unsafe void BeginUpdateObject(string aObjectID, string aCurrentTagValue, string aNewTagValue, CallbackAsyncComplete aCallback)
        {
			char* objectID = (char*)Marshal.StringToHGlobalAnsi(aObjectID);
			char* currentTagValue = (char*)Marshal.StringToHGlobalAnsi(aCurrentTagValue);
			char* newTagValue = (char*)Marshal.StringToHGlobalAnsi(aNewTagValue);
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgContentDirectory2BeginUpdateObject(iHandle, objectID, currentTagValue, newTagValue, iActionComplete, ptr);
			Marshal.FreeHGlobal((IntPtr)objectID);
			Marshal.FreeHGlobal((IntPtr)currentTagValue);
			Marshal.FreeHGlobal((IntPtr)newTagValue);
        }

        public unsafe void EndUpdateObject(uint aAsyncHandle)
        {
			{
				if (0 != CpProxyUpnpOrgContentDirectory2EndUpdateObject(iHandle, aAsyncHandle))
				{
					throw(new ProxyError());
				}
			}
        }

        public unsafe void SyncMoveObject(string aObjectID, string aNewParentID, out string aNewObjectID)
        {
			char* objectID = (char*)Marshal.StringToHGlobalAnsi(aObjectID);
			char* newParentID = (char*)Marshal.StringToHGlobalAnsi(aNewParentID);
			char* newObjectID;
			{
				CpProxyUpnpOrgContentDirectory2SyncMoveObject(iHandle, objectID, newParentID, &newObjectID);
			}
			Marshal.FreeHGlobal((IntPtr)objectID);
			Marshal.FreeHGlobal((IntPtr)newParentID);
            aNewObjectID = Marshal.PtrToStringAnsi((IntPtr)newObjectID);
            ZappFree(newObjectID);
        }

        public unsafe void BeginMoveObject(string aObjectID, string aNewParentID, CallbackAsyncComplete aCallback)
        {
			char* objectID = (char*)Marshal.StringToHGlobalAnsi(aObjectID);
			char* newParentID = (char*)Marshal.StringToHGlobalAnsi(aNewParentID);
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgContentDirectory2BeginMoveObject(iHandle, objectID, newParentID, iActionComplete, ptr);
			Marshal.FreeHGlobal((IntPtr)objectID);
			Marshal.FreeHGlobal((IntPtr)newParentID);
        }

        public unsafe void EndMoveObject(uint aAsyncHandle, out string aNewObjectID)
        {
			char* newObjectID;
			{
				if (0 != CpProxyUpnpOrgContentDirectory2EndMoveObject(iHandle, aAsyncHandle, &newObjectID))
				{
					throw(new ProxyError());
				}
			}
            aNewObjectID = Marshal.PtrToStringAnsi((IntPtr)newObjectID);
            ZappFree(newObjectID);
        }

        public unsafe void SyncImportResource(string aSourceURI, string aDestinationURI, out uint aTransferID)
        {
			char* sourceURI = (char*)Marshal.StringToHGlobalAnsi(aSourceURI);
			char* destinationURI = (char*)Marshal.StringToHGlobalAnsi(aDestinationURI);
			fixed (uint* transferID = &aTransferID)
			{
				CpProxyUpnpOrgContentDirectory2SyncImportResource(iHandle, sourceURI, destinationURI, transferID);
			}
			Marshal.FreeHGlobal((IntPtr)sourceURI);
			Marshal.FreeHGlobal((IntPtr)destinationURI);
        }

        public unsafe void BeginImportResource(string aSourceURI, string aDestinationURI, CallbackAsyncComplete aCallback)
        {
			char* sourceURI = (char*)Marshal.StringToHGlobalAnsi(aSourceURI);
			char* destinationURI = (char*)Marshal.StringToHGlobalAnsi(aDestinationURI);
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgContentDirectory2BeginImportResource(iHandle, sourceURI, destinationURI, iActionComplete, ptr);
			Marshal.FreeHGlobal((IntPtr)sourceURI);
			Marshal.FreeHGlobal((IntPtr)destinationURI);
        }

        public unsafe void EndImportResource(uint aAsyncHandle, out uint aTransferID)
        {
			fixed (uint* transferID = &aTransferID)
			{
				if (0 != CpProxyUpnpOrgContentDirectory2EndImportResource(iHandle, aAsyncHandle, transferID))
				{
					throw(new ProxyError());
				}
			}
        }

        public unsafe void SyncExportResource(string aSourceURI, string aDestinationURI, out uint aTransferID)
        {
			char* sourceURI = (char*)Marshal.StringToHGlobalAnsi(aSourceURI);
			char* destinationURI = (char*)Marshal.StringToHGlobalAnsi(aDestinationURI);
			fixed (uint* transferID = &aTransferID)
			{
				CpProxyUpnpOrgContentDirectory2SyncExportResource(iHandle, sourceURI, destinationURI, transferID);
			}
			Marshal.FreeHGlobal((IntPtr)sourceURI);
			Marshal.FreeHGlobal((IntPtr)destinationURI);
        }

        public unsafe void BeginExportResource(string aSourceURI, string aDestinationURI, CallbackAsyncComplete aCallback)
        {
			char* sourceURI = (char*)Marshal.StringToHGlobalAnsi(aSourceURI);
			char* destinationURI = (char*)Marshal.StringToHGlobalAnsi(aDestinationURI);
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgContentDirectory2BeginExportResource(iHandle, sourceURI, destinationURI, iActionComplete, ptr);
			Marshal.FreeHGlobal((IntPtr)sourceURI);
			Marshal.FreeHGlobal((IntPtr)destinationURI);
        }

        public unsafe void EndExportResource(uint aAsyncHandle, out uint aTransferID)
        {
			fixed (uint* transferID = &aTransferID)
			{
				if (0 != CpProxyUpnpOrgContentDirectory2EndExportResource(iHandle, aAsyncHandle, transferID))
				{
					throw(new ProxyError());
				}
			}
        }

        public unsafe void SyncDeleteResource(string aResourceURI)
        {
			char* resourceURI = (char*)Marshal.StringToHGlobalAnsi(aResourceURI);
			{
				CpProxyUpnpOrgContentDirectory2SyncDeleteResource(iHandle, resourceURI);
			}
			Marshal.FreeHGlobal((IntPtr)resourceURI);
        }

        public unsafe void BeginDeleteResource(string aResourceURI, CallbackAsyncComplete aCallback)
        {
			char* resourceURI = (char*)Marshal.StringToHGlobalAnsi(aResourceURI);
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgContentDirectory2BeginDeleteResource(iHandle, resourceURI, iActionComplete, ptr);
			Marshal.FreeHGlobal((IntPtr)resourceURI);
        }

        public unsafe void EndDeleteResource(uint aAsyncHandle)
        {
			{
				if (0 != CpProxyUpnpOrgContentDirectory2EndDeleteResource(iHandle, aAsyncHandle))
				{
					throw(new ProxyError());
				}
			}
        }

        public unsafe void SyncStopTransferResource(uint aTransferID)
        {
			{
				CpProxyUpnpOrgContentDirectory2SyncStopTransferResource(iHandle, aTransferID);
			}
        }

        public unsafe void BeginStopTransferResource(uint aTransferID, CallbackAsyncComplete aCallback)
        {
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgContentDirectory2BeginStopTransferResource(iHandle, aTransferID, iActionComplete, ptr);
        }

        public unsafe void EndStopTransferResource(uint aAsyncHandle)
        {
			{
				if (0 != CpProxyUpnpOrgContentDirectory2EndStopTransferResource(iHandle, aAsyncHandle))
				{
					throw(new ProxyError());
				}
			}
        }

        public unsafe void SyncGetTransferProgress(uint aTransferID, out string aTransferStatus, out string aTransferLength, out string aTransferTotal)
        {
			char* transferStatus;
			char* transferLength;
			char* transferTotal;
			{
				CpProxyUpnpOrgContentDirectory2SyncGetTransferProgress(iHandle, aTransferID, &transferStatus, &transferLength, &transferTotal);
			}
            aTransferStatus = Marshal.PtrToStringAnsi((IntPtr)transferStatus);
            ZappFree(transferStatus);
            aTransferLength = Marshal.PtrToStringAnsi((IntPtr)transferLength);
            ZappFree(transferLength);
            aTransferTotal = Marshal.PtrToStringAnsi((IntPtr)transferTotal);
            ZappFree(transferTotal);
        }

        public unsafe void BeginGetTransferProgress(uint aTransferID, CallbackAsyncComplete aCallback)
        {
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgContentDirectory2BeginGetTransferProgress(iHandle, aTransferID, iActionComplete, ptr);
        }

        public unsafe void EndGetTransferProgress(uint aAsyncHandle, out string aTransferStatus, out string aTransferLength, out string aTransferTotal)
        {
			char* transferStatus;
			char* transferLength;
			char* transferTotal;
			{
				if (0 != CpProxyUpnpOrgContentDirectory2EndGetTransferProgress(iHandle, aAsyncHandle, &transferStatus, &transferLength, &transferTotal))
				{
					throw(new ProxyError());
				}
			}
            aTransferStatus = Marshal.PtrToStringAnsi((IntPtr)transferStatus);
            ZappFree(transferStatus);
            aTransferLength = Marshal.PtrToStringAnsi((IntPtr)transferLength);
            ZappFree(transferLength);
            aTransferTotal = Marshal.PtrToStringAnsi((IntPtr)transferTotal);
            ZappFree(transferTotal);
        }

        public unsafe void SyncCreateReference(string aContainerID, string aObjectID, out string aNewID)
        {
			char* containerID = (char*)Marshal.StringToHGlobalAnsi(aContainerID);
			char* objectID = (char*)Marshal.StringToHGlobalAnsi(aObjectID);
			char* newID;
			{
				CpProxyUpnpOrgContentDirectory2SyncCreateReference(iHandle, containerID, objectID, &newID);
			}
			Marshal.FreeHGlobal((IntPtr)containerID);
			Marshal.FreeHGlobal((IntPtr)objectID);
            aNewID = Marshal.PtrToStringAnsi((IntPtr)newID);
            ZappFree(newID);
        }

        public unsafe void BeginCreateReference(string aContainerID, string aObjectID, CallbackAsyncComplete aCallback)
        {
			char* containerID = (char*)Marshal.StringToHGlobalAnsi(aContainerID);
			char* objectID = (char*)Marshal.StringToHGlobalAnsi(aObjectID);
            GCHandle gch = GCHandle.Alloc(aCallback);
            IntPtr ptr = GCHandle.ToIntPtr(gch);
            CpProxyUpnpOrgContentDirectory2BeginCreateReference(iHandle, containerID, objectID, iActionComplete, ptr);
			Marshal.FreeHGlobal((IntPtr)containerID);
			Marshal.FreeHGlobal((IntPtr)objectID);
        }

        public unsafe void EndCreateReference(uint aAsyncHandle, out string aNewID)
        {
			char* newID;
			{
				if (0 != CpProxyUpnpOrgContentDirectory2EndCreateReference(iHandle, aAsyncHandle, &newID))
				{
					throw(new ProxyError());
				}
			}
            aNewID = Marshal.PtrToStringAnsi((IntPtr)newID);
            ZappFree(newID);
        }

        public void SetPropertySystemUpdateIDChanged(CallbackPropertyChanged aSystemUpdateIDChanged)
        {
            iSystemUpdateIDChanged = aSystemUpdateIDChanged;
            iCallbackSystemUpdateIDChanged = new Callback(PropertySystemUpdateIDChanged);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            CpProxyUpnpOrgContentDirectory2SetPropertySystemUpdateIDChanged(iHandle, iCallbackSystemUpdateIDChanged, ptr);
        }

        private void PropertySystemUpdateIDChanged(IntPtr aPtr)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            CpProxyUpnpOrgContentDirectory2 self = (CpProxyUpnpOrgContentDirectory2)gch.Target;
            self.iSystemUpdateIDChanged();
        }

        public void SetPropertyContainerUpdateIDsChanged(CallbackPropertyChanged aContainerUpdateIDsChanged)
        {
            iContainerUpdateIDsChanged = aContainerUpdateIDsChanged;
            iCallbackContainerUpdateIDsChanged = new Callback(PropertyContainerUpdateIDsChanged);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            CpProxyUpnpOrgContentDirectory2SetPropertyContainerUpdateIDsChanged(iHandle, iCallbackContainerUpdateIDsChanged, ptr);
        }

        private void PropertyContainerUpdateIDsChanged(IntPtr aPtr)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            CpProxyUpnpOrgContentDirectory2 self = (CpProxyUpnpOrgContentDirectory2)gch.Target;
            self.iContainerUpdateIDsChanged();
        }

        public void SetPropertyTransferIDsChanged(CallbackPropertyChanged aTransferIDsChanged)
        {
            iTransferIDsChanged = aTransferIDsChanged;
            iCallbackTransferIDsChanged = new Callback(PropertyTransferIDsChanged);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            CpProxyUpnpOrgContentDirectory2SetPropertyTransferIDsChanged(iHandle, iCallbackTransferIDsChanged, ptr);
        }

        private void PropertyTransferIDsChanged(IntPtr aPtr)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            CpProxyUpnpOrgContentDirectory2 self = (CpProxyUpnpOrgContentDirectory2)gch.Target;
            self.iTransferIDsChanged();
        }

        public unsafe void PropertySystemUpdateID(out uint aSystemUpdateID)
        {
			fixed (uint* systemUpdateID = &aSystemUpdateID)
			{
	            CpProxyUpnpOrgContentDirectory2PropertySystemUpdateID(iHandle, systemUpdateID);
			}
        }

        public unsafe void PropertyContainerUpdateIDs(out string aContainerUpdateIDs)
        {
			char* ptr;
            CpProxyUpnpOrgContentDirectory2PropertyContainerUpdateIDs(iHandle, &ptr);
            aContainerUpdateIDs = Marshal.PtrToStringAnsi((IntPtr)ptr);
            ZappFree(ptr);
        }

        public unsafe void PropertyTransferIDs(out string aTransferIDs)
        {
			char* ptr;
            CpProxyUpnpOrgContentDirectory2PropertyTransferIDs(iHandle, &ptr);
            aTransferIDs = Marshal.PtrToStringAnsi((IntPtr)ptr);
            ZappFree(ptr);
        }

        public void Dispose()
        {
            DoDispose(true);
        }

        ~CpProxyUpnpOrgContentDirectory2()
        {
            DoDispose(false);
        }

        private void DoDispose(bool aDisposing)
        {
            lock (this)
            {
                if (iHandle == 0)
                {
                    return;
                }
                CpProxyUpnpOrgContentDirectory2Destroy(iHandle);
                iHandle = 0;
            }
            iGch.Free();
            if (aDisposing)
            {
                GC.SuppressFinalize(this);
            }
            else
            {
                DisposeProxy();
            }
        }
    }
}

