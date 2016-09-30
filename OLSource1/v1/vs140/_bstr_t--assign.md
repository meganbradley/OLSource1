---
title: "_bstr_t::Assign"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "_bstr_t::Assign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Assign method"
ms.assetid: 2e209bbe-77ca-4598-86d5-6c2ea213f43c
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _bstr_t::Assign
**Microsoft Specific**  
  
 Copies a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> into the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> wrapped by a **_**<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to be copied into the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> wrapped by a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> does a binary copy, which means the entire length of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is copied, regardless of content.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **bstrWrapper = some text**  
**bstrWrapper = (null)**  
**bstr = some text**  
**bstrWrapper = SysAllocedString**  
**bstrWrapper = some text**  
**bstrWrapper = Yet another string**  
**bstrWrapper2 = some text**  
**bstrWrapper = changing BSTR**  
**bstrWrapper2 = some text**   
## END Microsoft Specific  
  
## See Also  
 [_bstr_t Class](../vs140/_bstr_t-class.md)