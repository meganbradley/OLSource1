---
title: "CWinAppEx::WriteSectionInt"
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
  - "WriteSectionInt"
  - "CWinAppEx.WriteSectionInt"
  - "CWinAppEx::WriteSectionInt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WriteSectionInt method"
ms.assetid: d100957e-186c-4242-9525-002de43e90d3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::WriteSectionInt
Writes numeric data to the registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A string that contains the relative path of a registry key.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A string that contains the value to set.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The data to write to the registry.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if this method is successful; otherwise <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter is not an absolute path for a registry entry. It is a relative path that is appended to the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md) and [CWinAppEx::SetRegistryBase](../vs140/cwinappex--setregistrybase.md) respectively.  
  
 If the key specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> does not exist, this method will create it.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)