---
title: "CCmdTarget::GetTypeLib"
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
  - "CCmdTarget::GetTypeLib"
  - "GetTypeLib"
  - "CCmdTarget.GetTypeLib"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTypeLib method"
  - "CCmdTarget class, attributes"
ms.assetid: 66c08e0f-3d7e-4ab8-b4f0-b17b969f12de
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCmdTarget::GetTypeLib
Gets a pointer to a type library.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A locale identifier (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a pointer to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> interface.  
  
## Return Value  
 An HRESULT indicating the success or failure of the call. If successful, *<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> points to the type library interface.  
  
## Remarks  
 Derived classes should override this member function (if not overridden, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns TYPE_E_CANTLOADLIBRARY). Use the [IMPLEMENT_OLETYPELIB](../vs140/implement_oletypelib.md) macro, which also implements <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCmdTarget Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCmdTarget::GetTypeInfoCount](../vs140/ccmdtarget--gettypeinfocount.md)   
 [CCmdTarget::GetTypeLibCache](../vs140/ccmdtarget--gettypelibcache.md)