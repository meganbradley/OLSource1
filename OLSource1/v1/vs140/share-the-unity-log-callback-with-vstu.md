---
title: "Share the Unity Log Callback with VSTU"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "tgt-pltfrm-cross-plat"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 5d71f906-6e50-4399-b59b-d38c6dfef7ee
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Share the Unity Log Callback with VSTU
Visual Studio Tools for Unity registers a log callback with Unity to be able to stream its console to Visual Studio. If your editor scripts also register a log callback with Unity, the VSTU callback might interfere with your callback. To prevent this possibility, use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> event to cooperate with VSTU.  
  
## Demonstrates  
 How to share the Unity Log Callback created by Visual Studio Tools for Unity.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Customize Project Files Created by VSTU](../vs140/customize-project-files-created-by-vstu.md)