---
title: "File Permission Constants"
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
  - "_S_IWRITE"
  - "_S_IREAD"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "S_IWRITE constant"
  - "constants [C++], file attributes"
  - "S_IREAD constant"
  - "file permissions [C++]"
  - "_S_IWRITE constant"
  - "_S_IREAD constant"
ms.assetid: 593cad33-31d1-44d2-8941-8af7d210c88c
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# File Permission Constants
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 One of these constants is required when <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) is specified.  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> argument specifies the file's permission settings as follows.  
  
|Constant|Meaning|  
|--------------|-------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Reading permitted|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Writing permitted|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Reading and writing permitted|  
  
 When used as the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> argument for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the manifest constant sets the permission setting, as follows.  
  
|Constant|Meaning|  
|--------------|-------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Writing not permitted (file is read-only)|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Reading not permitted (file is write-only)|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Neither reading nor writing permitted|  
  
## See Also  
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_sopen, _wsopen](../vs140/_sopen--_wsopen.md)   
 [_umask](../vs140/_umask.md)   
 [Standard Types](../vs140/standard-types.md)   
 [Global Constants](../vs140/global-constants.md)