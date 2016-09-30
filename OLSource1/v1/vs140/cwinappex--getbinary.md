---
title: "CWinAppEx::GetBinary"
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
  - "GetBinary"
  - "CWinAppEx::GetBinary"
  - "CWinAppEx.GetBinary"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBinary method"
ms.assetid: 32ae26a8-9347-4f0e-8bee-937738fb6147
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::GetBinary
Reads binary data from a specified registry key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A string that contains the name of a registry key.  
  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the buffer that the method fills with the binary data.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to an unsigned integer that the method uses to write the number of bytes read.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if successful; <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> otherwise.  
  
## Remarks  
 This method reads binary data written to the registry. To write data to the registry, use the methods [CWinAppEx::WriteBinary](../vs140/cwinappex--writebinary.md) and [CWinAppEx::WriteSectionBinary](../vs140/cwinappex--writesectionbinary.md).  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter is the name of a registry entry located under the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md) and [CWinAppEx::SetRegistryBase](../vs140/cwinappex--setregistrybase.md) respectively.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::WriteBinary](../vs140/cwinappex--writebinary.md)   
 [CWinAppEx::WriteSectionBinary](../vs140/cwinappex--writesectionbinary.md)