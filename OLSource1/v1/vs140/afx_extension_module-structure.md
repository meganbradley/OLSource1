---
title: "AFX_EXTENSION_MODULE Structure"
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
  - "AFX_EXTENSION_MODULE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AFX_EXTENSION_MODULE structure"
ms.assetid: b85a989c-d0c5-4b28-b53c-dad45b75704e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_EXTENSION_MODULE Structure
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is used during initialization of MFC extension DLLs to hold the state of extension DLL module.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *bInitialized*  
 **TRUE** if the DLL module has been initialized with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the handle of the DLL module.  
  
 *hResource*  
 Specifies the handle of the DLL custom resource module.  
  
 *pFirstSharedClass*  
 A pointer to information (the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure) about the DLL module's first runtime class. Used to provide the start of the runtime class list.  
  
 *pFirstSharedFactory*  
 A pointer to the DLL module's first object factory (a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object). Used to provide the start of the class factory list.  
  
## Remarks  
 MFC extension DLLs need to do two things in their <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function:  
  
-   Call [AfxInitExtensionModule](../vs140/afxinitextensionmodule.md) and check the return value.  
  
-   Create a **CDynLinkLibrary** object if the DLL will be exporting [CRuntimeClass](../vs140/cruntimeclass-structure.md) objects or has its own custom resources.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> structure is used to hold a copy of the extension DLL module state, including a copy of the runtime class objects that have been initialized by the extension DLL as part of normal static object construction executed before <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is entered. For example:  
  
 [!code[NVC_MFC_DLL#2](../vs140/codesnippet/CPP/afx_extension_module-structure_1.cpp)]  
  
 The module information stored in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> structure can be copied into the **CDynLinkLibrary** object. For example:  
  
 [!code[NVC_MFC_DLL#5](../vs140/codesnippet/CPP/afx_extension_module-structure_2.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [AfxInitExtensionModule](../vs140/afxinitextensionmodule.md)   
 [AfxTermExtensionModule](../vs140/afxtermextensionmodule.md)