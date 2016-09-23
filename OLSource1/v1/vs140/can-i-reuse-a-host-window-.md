---
title: "Can I Reuse a Host Window?"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - host windows
ms.assetid: bcd08ab1-cfcf-49e3-b4e8-ac134d141005
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Can I Reuse a Host Window?
It is not recommended that you reuse host windows. To ensure the robustness of your code, you should tie the lifetime of your host window to the lifetime of a single control.  
  
## See Also  
 [Control Containment FAQ](../vs140/atl-control-containment-faq.md)