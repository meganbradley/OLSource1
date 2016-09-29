---
title: "&#39;Dir&#39; function must first be called with a &#39;PathName&#39; argument"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbrDIR_IllegalCall"
dev_langs: 
  - "VB"
ms.assetid: 7b5d149f-be91-4ac3-8262-86a360894e7d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Dir&#39; function must first be called with a &#39;PathName&#39; argument
An initial call to the `Dir` function does not include the `PathName` argument. The first call to `Dir` must include a `PathName`, but subsequent calls to `Dir` do not need to include parameters to retrieve the next item.  
  
### To correct this error  
  
1.  Supply a `PathName` argument in the function call.  
  
## See Also  
 <xref:Microsoft.VisualBasic.FileSystem.Dir*>