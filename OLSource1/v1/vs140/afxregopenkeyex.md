---
title: "AfxRegOpenKeyEx"
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
  - "AfxRegOpenKeyEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxRegOpenKeyEx"
ms.assetid: 6cfab355-ffdd-43b4-ae22-ba4a61f2f8f5
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxRegOpenKeyEx
Opens the specified registry key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A handle to an open registry key.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of a key that this function opens or creates.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This parameter is reserved and must be zero.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A mask that specifies the desired access rights to the key.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to a variable that receives a handle to the opened key.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
## Return Value  
 If the function succeeds, the return value is ERROR_SUCCESS. If the function fails, the return value is a nonzero error code defined in Winerror.h.  
  
## Remarks  
  
## Requirements  
 **Header:** afxpriv.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)