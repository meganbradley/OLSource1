---
title: "CWinAppEx::WriteObject"
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
  - "CWinAppEx::WriteObject"
  - "CWinAppEx.WriteObject"
  - "WriteObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WriteObject method"
ms.assetid: 525a9ce5-85a6-43ea-9ae4-e121456054b9
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::WriteObject
Writes data derived from the [CObject Class](../vs140/cobject-class.md) to the registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A string that contains the value to set.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> data that the method will store.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if this method is successful; otherwise <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method writes the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> data to the specified value under the default registry key. Use [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md) to determine the current registry key.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)