---
title: "CWinAppEx::WriteSectionString"
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
  - "WriteSectionString"
  - "CWinAppEx.WriteSectionString"
  - "CWinAppEx::WriteSectionString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WriteSectionString method"
ms.assetid: 6cb5d442-81f2-4031-aaec-fae00ad62f8b
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::WriteSectionString
Writes string data to a value in the registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A string that contains the name of a registry key.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A string that contains the value to set.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The string data to write to the registry.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if this method is successful; otherwise <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter is not an absolute path for a registry entry. It is a relative path that is appended to the end of the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md) and [CWinAppEx::SetRegistryBase](../vs140/cwinappex--setregistrybase.md), respectively.  
  
 If the value specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> does not exist under <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, this method will create it.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)