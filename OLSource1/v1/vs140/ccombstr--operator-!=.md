---
title: "CComBSTR::operator !="
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
  - "ATL::CComBSTR::operator!="
  - "CComBSTR::operator!="
  - "CComBSTR.operator!="
  - "ATL.CComBSTR.operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator !=, bstr"
  - "!= operator"
  - "operator!=, bstr"
ms.assetid: 69888f59-8701-4471-bf99-522244ecf5f7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComBSTR::operator !=
Returns the logical opposite of [operator ==](../vs140/ccombstr--operator-==.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A zero-terminated string.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Must be **NULL**.  
  
## Return Value  
 Returns **true** if the item being compared is not equal to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object; otherwise, returns **false**.  
  
## Remarks  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>s are compared textually in the context of the user's default locale. The final comparison operator just compares the contained string against **NULL**.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComBSTR Class](../vs140/ccombstr-class.md)