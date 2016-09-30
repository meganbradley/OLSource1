---
title: "CSimpleMapEqualHelperFalse::IsEqualValue"
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
  - "ATL::CSimpleMapEqualHelperFalse::IsEqualValue"
  - "CSimpleMapEqualHelperFalse.IsEqualValue"
  - "ATL.CSimpleMapEqualHelperFalse.IsEqualValue"
  - "IsEqualValue"
  - "CSimpleMapEqualHelperFalse::IsEqualValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsEqualValue method"
ms.assetid: ba001ada-f091-4072-8699-8882ef730374
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleMapEqualHelperFalse::IsEqualValue
Returns false.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns false.  
  
## Remarks  
 This method always returns false, and will call <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> with an argument of false if it is ever referenced. The purpose of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is to force methods using comparisons to fail in a well-defined manner when equality tests have not been adequately defined.  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
## See Also  
 [CSimpleMapEqualHelperFalse Class](../vs140/csimplemapequalhelperfalse-class.md)   
 [CSimpleMapEqualHelperFalse::IsEqualKey](../vs140/csimplemapequalhelperfalse--isequalkey.md)