static AFX_EXTENSION_MODULE NVC_MFC_DLLDLL = { NULL, NULL };
extern "C" int APIENTRY
DllMain(HINSTANCE hInstance, DWORD dwReason, LPVOID lpReserved)
{
	// Remove this if you use lpReserved
	UNREFERENCED_PARAMETER(lpReserved);

	if (dwReason == DLL_PROCESS_ATTACH)
	{
		TRACE0("NVC_MFC_DLL.DLL Initializing!\n");
		
		// Extension DLL one-time initialization
		if (!AfxInitExtensionModule(NVC_MFC_DLLDLL, hInstance))
			return 0;

		new CMyDynLinkLibrary(NVC_MFC_DLLDLL);

	}
	else if (dwReason == DLL_PROCESS_DETACH)
	{
		TRACE0("NVC_MFC_DLL.DLL Terminating!\n");

		// Terminate the library before destructors are called
		AfxTermExtensionModule(NVC_MFC_DLLDLL);
	}
	return 1;   // ok
}