---
title: "CPathT::RenameExtension"
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
  - "RenameExtension"
  - "CPathT::RenameExtension"
  - "ATL::CPathT::RenameExtension"
  - "ATL.CPathT<StringType>.RenameExtension"
  - "ATL::CPathT<StringType>::RenameExtension"
  - "CPathT.RenameExtension"
  - "ATL.CPathT.RenameExtension"
  - "CPathT<StringType>::RenameExtension"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RenameExtension method"
ms.assetid: 9e09423d-331b-4e58-af24-f85269ec7336
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPathT::RenameExtension
Call this method to replace the file name extension in the path with a new extension. If the file name does not contain an extension, the extension will be attached to the end of the path.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The new file name extension, preceded by a "." character.  
  
## Return Value  
 Returns TRUE on success, FALSE on failure.  
  
## Remarks  
 For more information, see [PathRenameExtension](http://msdn.microsoft.com/library/windows/desktop/bb773749).  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [CPathT Class](../vs140/cpatht-class.md)