---
title: "-SWAPRUN"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/SWAPRUN"
f1_keywords: 
  - "/swaprun"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/SWAPRUN editbin option"
  - "-SWAPRUN editbin option"
  - "SWAPRUN editbin option"
ms.assetid: 6eefd7f3-ca47-48e3-8509-323d27cf4ae7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -SWAPRUN
```  
/SWAPRUN:{[!]NET|[!]CD}  
```  
  
## Remarks  
 This option edits the image to tell the operating system to copy the image to a swap file and run it from there. Use this option for images that reside on networks or removable media.  
  
 You can add or remove the NET or CD qualifiers:  
  
-   NET indicates that the image resides on a network.  
  
-   CD indicates that the image resides on a CD-ROM or similar removable medium.  
  
-   Use !NET and !CD to reverse the effects of NET and CD.  
  
## See Also  
 [EDITBIN Options](../vs140/editbin-options.md)