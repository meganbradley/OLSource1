---
title: "VCPROFILE_ALLOC_SCALE"
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
  - "VCPROFILE_ALLOC_SCALE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "VCPROFILE_ALLOC_SCALE environment variable"
ms.assetid: 5cb5ce27-f9b8-489b-b46c-d6e9bcab2d34
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# VCPROFILE_ALLOC_SCALE
Modify the amount of memory allocated to hold the profile data.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The scale value for the amount of memory you want for running test scenarios.  The default is 1.  
  
## Remarks  
 In rare cases, there will not be enough memory available to support gathering profile data when running test scenarios.  In those cases, you can increase the amount of memory with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 If you receive an error message during a test run that indicates that you have insufficient memory, assign a larger value to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, until the test runs complete with no out-of-memory errors.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Environment Variables for Profile-Guided Optimizations](../vs140/environment-variables-for-profile-guided-optimizations.md)