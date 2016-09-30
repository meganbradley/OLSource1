---
title: "_stat Structure st_mode Field Constants"
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
  - "S_IFCHR"
  - "S_IFDIR"
  - "_S_IWRITE"
  - "S_IFMT"
  - "_S_IFDIR"
  - "_S_IREAD"
  - "S_IEXEC"
  - "_S_IEXEC"
  - "_S_IFMT"
  - "S_IWRITE"
  - "S_IFREG"
  - "S_IREAD"
  - "_S_IFCHR"
  - "_S_IFREG"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "S_IFDIR constant"
  - "stat structure"
  - "S_IWRITE constant"
  - "S_IEXEC constant"
  - "_S_IFREG constant"
  - "S_IREAD constant"
  - "stat structure, constants"
  - "_S_IFMT constant"
  - "st_mode field constants"
  - "S_IFMT constant"
  - "_S_IEXEC constant"
  - "_S_IWRITE constant"
  - "_S_IFDIR constant"
  - "S_IFREG constant"
  - "S_IFCHR constant"
  - "_S_IREAD constant"
  - "_S_IFCHR constant"
ms.assetid: fd462004-7563-4766-8443-30b0a86174b6
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _stat Structure st_mode Field Constants
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 These constants are used to indicate file type in the **st_mode** field of the [_stat structure](../vs140/standard-types.md).  
  
 The bit mask constants are described below:  
  
|Constant|Meaning|  
|--------------|-------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|File type mask|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Directory|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Character special (indicates a device if set)|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Regular|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Read permission, owner|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Write permission, owner|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Execute/search permission, owner|  
  
## See Also  
 [_stat, _wstat Functions](../vs140/99a75ae6-ff26-47ad-af70-5ea7e17226a5.md)   
 [_fstat, _fstat32, _fstat64, _fstati64, _fstat32i64, _fstat64i32](../vs140/_fstat--_fstat32--_fstat64--_fstati64--_fstat32i64--_fstat64i32.md)   
 [Standard Types](../vs140/standard-types.md)   
 [Global Constants](../vs140/global-constants.md)