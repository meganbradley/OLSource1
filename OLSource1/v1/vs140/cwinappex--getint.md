---
title: "CWinAppEx::GetInt"
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
  - "GetInt"
  - "CWinAppEx::GetInt"
  - "CWinAppEx.GetInt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetInt method"
ms.assetid: 9e441fb4-f417-4429-941c-e1bc067dab7a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::GetInt
Reads integer data from a specified registry key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A string that contains the name of a registry entry.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The default value that the method returns if the specified registry entry does not exist.  
  
## Return Value  
 The registry data if the method was successful; otherwise <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method reads integer data from the registry. If there is no integer data associated with the registry key indicated by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, this method returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. To write data to the registry, use the methods [CWinAppEx::WriteSectionInt](../vs140/cwinappex--writesectionint.md) and [CWinAppEx::WriteInt](../vs140/cwinappex--writeint.md).  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter is the name of a registry entry located under the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md) and [CWinAppEx::SetRegistryBase](../vs140/cwinappex--setregistrybase.md) respectively.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::WriteInt](../vs140/cwinappex--writeint.md)   
 [CWinAppEx::WriteSectionInt](../vs140/cwinappex--writesectionint.md)