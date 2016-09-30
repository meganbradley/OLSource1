---
title: "CWinAppEx::GetObjectA"
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
  - "CWinAppEx.GetObjectA"
  - "GetObjectA"
  - "CWinAppEx::GetObjectA"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetObjectA method"
ms.assetid: f3b4f17e-4645-40d7-98c0-1fd50e920d2e
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::GetObjectA
Reads <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>-derived data from the registry. This is the MBCS form of the [CWinAppEx::GetObject](../vs140/cwinappex--getobject.md) function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A string that contains the relative path of a registry entry.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A reference to a CObject. The method uses this reference to store the registry data.  
  
## Return Value  
 Nonzero if the method was successful; otherwise 0.  
  
## Remarks  
 See [CWinAppEx::GetObject](../vs140/cwinappex--getobject.md).  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)