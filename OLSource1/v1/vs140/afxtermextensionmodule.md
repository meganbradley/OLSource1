---
title: "AfxTermExtensionModule"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AfxTermExtensionModule"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxTermExtensionModule function"
  - "DLLs [C++], extension"
  - "extension DLLs [C++], cleanup"
ms.assetid: b64de402-f1e3-4c26-9823-08c07876aaaa
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxTermExtensionModule
Call this function to allow MFC to cleanup the extension DLL when each process detaches from the DLL (which happens when the process exits, or when the DLL is unloaded as a result of a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> call).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to the [AFX_EXTENSION_MODULE](../vs140/afx_extension_module-structure.md) structure that contains the state of extension DLL module.  
  
 *bAll*  
 If **TRUE**, cleanup all extension DLL modules. Otherwise, cleanup only the current DLL module.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> will delete any local storage attached to the module and remove any entries from the message map cache. For example:  
  
 [!code[NVC_MFC_DLL#4](../vs140/codesnippet/CPP/afxtermextensionmodule_1.cpp)]  
  
 If your application loads and frees extension DLLs dynamically, be sure to call <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Since most extension DLLs are not dynamically loaded (usually, they are linked via their import libraries), the call to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is usually not necessary.  
  
 MFC extension DLLs need to call [AfxInitExtensionModule](../vs140/afxinitextensionmodule.md) in their <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If the DLL will be exporting [CRuntimeClass](../vs140/cruntimeclass-structure.md) objects or has its own custom resources, you also need to create a **CDynLinkLibrary** object in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxdll_.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxInitExtensionModule](../vs140/afxinitextensionmodule.md)