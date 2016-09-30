---
title: "CSid::IsValid"
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
  - "CSid.IsValid"
  - "ATL.CSid.IsValid"
  - "ATL::CSid::IsValid"
  - "CSid::IsValid"
  - "IsValid"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsValid method"
ms.assetid: bdb22010-2773-4008-9876-d0ffad366f69
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSid::IsValid
Tests the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object for validity.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns **true** if the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object is valid, **false** if not. There is no extended error information for this method; do not call <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method validates the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object by verifying that the revision number is within a known range and that the number of subauthorities is less than the maximum.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSid Class](../vs140/csid-class.md)