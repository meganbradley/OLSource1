---
title: "CWinAppEx::WriteBinary"
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
  - "CWinAppEx::WriteBinary"
  - "WriteBinary"
  - "CWinAppEx.WriteBinary"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WriteBinary method"
ms.assetid: ae423d17-7f03-489d-a4cb-f765d474e56a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::WriteBinary
Writes binary data to the registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A string that contains the name of a registry key.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The data to store.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The size of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in bytes.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if this method is successful; otherwise <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter is the name of a registry entry that is located under the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md) and [CWinAppEx::SetRegistryBase](../vs140/cwinappex--setregistrybase.md) respectively.  
  
 If the key specified by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> does not exist, this method will create it.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)