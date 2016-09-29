---
title: "Variable uses an Automation type not supported in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbrID458"
dev_langs: 
  - "VB"
ms.assetid: bde4f4da-493b-452c-b6e4-1d370edba4cd
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Variable uses an Automation type not supported in Visual Basic
You tried to use a variable defined in a type library or object library that has a data type not supported by [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)].  
  
### To correct this error  
  
-   Use a variable of a type recognized by [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)].  
  
     -or-  
  
-   If you encounter this error while using `FileGet` or `FileGetOBject`, make sure the file you are trying to use was written to with `FilePut` or `FilePutObject`.  
  
## See Also  
 [Data Type Summary (Visual Basic)](../vs140/data-type-summary--visual-basic-.md)