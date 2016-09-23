---
title: "CPathT::BuildRoot"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - BuildRoot
  - CPathT<StringType>.BuildRoot
  - ATL::CPathT::BuildRoot
  - ATL.CPathT.BuildRoot
  - CPathT::BuildRoot
  - CPathT.BuildRoot
  - ATL::CPathT<StringType>::BuildRoot
  - CPathT<StringType>::BuildRoot
  - ATL.CPathT<StringType>.BuildRoot
dev_langs: 
  - C++
helpviewer_keywords: 
  - BuildRoot method
ms.assetid: 3579d163-4dbb-4273-9bbe-13073d3b48ef
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPathT::BuildRoot
Call this method to create a root path from a given drive number.  
  
## Syntax  
  
```  
  
      void BuildRoot(  
   int iDrive   
);  
```  
  
#### Parameters  
 *iDrive*  
 The drive number (0 is A:, 1 is B:, and so on).  
  
## Remarks  
 For more information, see [PathBuildRoot](http://msdn.microsoft.com/library/windows/desktop/bb773567).  
  
## Requirements  
 **Header:** atlpath.h  
  
## See Also  
 [CPathT Class](../vs140/cpatht-class.md)   
 [CPathT::GetDriveNumber](../vs140/cpatht--getdrivenumber.md)