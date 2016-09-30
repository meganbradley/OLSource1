---
title: "CComObjectRootEx::ObjectMain"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ObjectMain"
  - "CComObjectRootEx::ObjectMain"
  - "CComObjectRootEx.ObjectMain"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ObjectMain method"
ms.assetid: c388d5d6-a67c-4296-ac19-1af7ca9d3ebd
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectRootEx::ObjectMain
For each class listed in the [object map](assetId:///b57619cc-534f-4b8f-bfd4-0c12f937202f), this function is called once when the module is initialized, and again when it is terminated.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] The value is **true** if the class is being initialized; otherwise **false**.  
  
## Remarks  
 The value of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter indicates whether the module is being initialized or terminated. The default implementation of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> does nothing, but you can override this function in your class to initialize or clean up resources that you want to allocate for the class. Note that <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is called before any instances of the class are requested.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is called from the entry point of the DLL, so the type of operation that the entry-point function can perform is restricted. For more information on these restrictions, see [Run-Time Library Behavior](../vs140/run-time-library-behavior.md) and [DllMain](http://msdn.microsoft.com/library/windows/desktop/ms682583).  
  
## Example  
 [!code[NVC_ATL_COM#41](../vs140/codesnippet/CPP/ccomobjectrootex--objectmain_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObjectRootEx Class](../vs140/ccomobjectrootex-class.md)