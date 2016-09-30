---
title: "Using Database, OLE, and Sockets Extension DLLs in Regular DLLs"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DLLs [C++], initializing"
  - "DLLs [C++], extension"
  - "DLLs [C++], regular"
ms.assetid: 9f1d14a7-9e2a-4760-b3b6-db014fcdb7ff
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Database, OLE, and Sockets Extension DLLs in Regular DLLs
When using an extension DLL from a regular DLL, if the extension DLL is not wired into the **CDynLinkLibrary** object chain of the regular DLL, you might run into one or more of a set of related problems. Because the debug versions of the MFC Database, OLE, and Sockets support DLLs are implemented as extension DLLs, you might see similar problems if you are using these MFC features, even if you are not explicitly using any of your own extension DLLs. Some symptoms are:  
  
-   When attempting to deserialize an object of a type of class defined in the extension DLL, the message "Warning: Cannot load CYourClass from archive. Class not defined." appears in the TRACE debug window and the object fails to serialize.  
  
-   An exception indicating bad class might be thrown.  
  
-   Resources stored in the extension DLL fail to load because <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns **NULL** or an incorrect resource handle.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> member functions of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> fail to locate a class factory defined in the extension DLL.  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> does not work for any classes in the extension DLL.  
  
-   Standard MFC database, sockets, or OLE resources fail to load. For example, **AfxLoadString**(**AFX_IDP_SQL_CONNECT_FAIL**) returns an empty string, even when the regular DLL is properly using the MFC Database classes.  
  
 The solution to these problems is to create and export an initialization function in the extension DLL that creates a **CDynLinkLibrary** object. Call this initialization function exactly once from each regular DLL that uses the extension DLL.  
  
## MFC OLE, MFC Database (or DAO), or MFC Sockets Support  
 If you are using any MFC OLE, MFC Database (or DAO), or MFC Sockets support in your regular DLL, respectively, the MFC debug extension DLLs MFCOxxD.dll, MFCDxxD.dll, and MFCNxxD.dll (where xx is the version number) are linked automatically. You must call a predefined initialization function for each of these DLLs that you are using.  
  
 For database support, add a call to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to your regular DLL's <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function. Make sure this call occurs before any base-class call or any added code which accesses the MFCDxxD.dll. This function takes no parameters and returns void.  
  
 For OLE support, add a call to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to your regular DLL's <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Note that the **COleControlModule InitInstance** function calls <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> already, so if you are building an OLE control and are using <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, you should not add this call to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 For Sockets support, add a call to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to your regular DLL's <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 Note that release builds of MFC DLLs and applications do not use separate DLLs for database, sockets, or OLE support. However, it is safe to call these initialization functions in release mode.  
  
## CDynLinkLibrary Objects  
 During each of the operations mentioned at the beginning of this topic, MFC needs to search for a desired value or object. For example, during deserialization, MFC needs to search through all the currently available run-time classes to match objects in the archive with their proper run-time class.  
  
 As a part of these searches, MFC scans through all the extension DLLs in use by walking a chain of **CDynLinkLibrary** objects. **CDynLinkLibrary** objects attach automatically to a chain during their construction and are created by each extension DLL in turn during initialization. In addition, every module (application or regular DLL) has its own chain of **CDynLinkLibrary** objects.  
  
 For an extension DLL to get wired into a **CDynLinkLibrary** chain, it must create a **CDynLinkLibrary** object in the context of every module that uses the extension DLL. Therefore, if an extension DLL is going to be used from regular DLLs, it must provide an exported initialization function that creates a **CDynLinkLibrary** object. Every regular DLL that uses the extension DLL must call the exported initialization function.  
  
 If an extension DLL is only going to be used from an MFC application (.exe) and never from a regular DLL, then it is sufficient to create the **CDynLinkLibrary** object in the extension DLL's <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. This is what the MFC DLL Wizard extension DLL code does. When loading an extension DLL implicitly, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> loads and executes before the application ever starts. Any **CDynLinkLibrary** creations are wired into a default chain that the MFC DLL reserves for an MFC application.  
  
 Note that it is a bad idea to have multiple **CDynLinkLibrary** objects from one extension DLL in any one chain, especially if the extension DLL will be dynamically unloaded from memory. Do not call the initialization function more than once from any one module.  
  
## Sample Code  
 This sample code assumes that the regular DLL is implicitly linking to the extension DLL. This is accomplished by linking to the import library (.lib) of the extension DLL when building the regular DLL.  
  
 The following lines should be in the source of the extension DLL:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Be sure to export the **InitYourExtDLL** function. This could be done using **__declspec(dllexport)** or in your DLL's .def file as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Add a call to the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> member of the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>-derived object in each regular DLL using the extension DLL:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### What do you want to do?  
  
-   [Initialize an extension DLL](../vs140/initializing-extension-dlls.md)  
  
-   [Initialize regular DLLs](../vs140/initializing-regular-dlls.md)  
  
### What do you want to know more about?  
  
-   [Extension DLLs](../vs140/extension-dlls.md)  
  
-   [Regular DLLs Statically Linked to MFC](../vs140/regular-dlls-statically-linked-to-mfc.md)  
  
-   [Regular DLLs Dynamically Linked to MFC](../vs140/regular-dlls-dynamically-linked-to-mfc.md)  
  
-   [Using MFC as Part of a DLL](../vs140/tn011--using-mfc-as-part-of-a-dll.md)  
  
-   [DLL Version of MFC](../vs140/tn033--dll-version-of-mfc.md)  
  
## See Also  
 [Extension DLLs](../vs140/extension-dlls.md)