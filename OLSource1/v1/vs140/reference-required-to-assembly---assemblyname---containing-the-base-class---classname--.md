---
title: "Reference required to assembly &#39;&lt;assemblyname&gt;&#39; containing the base class &#39;&lt;classname&gt;&#39;"
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
  - "bc30007"
  - "vbc30007"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30007"
ms.assetid: 5f34cf47-6c6e-4954-bd8e-d6b020b75fb7
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Reference required to assembly &#39;&lt;assemblyname&gt;&#39; containing the base class &#39;&lt;classname&gt;&#39;
Reference required to assembly '\<assemblyname>' containing the base class '\<classname>'. Add one to your project.  
  
 The class is defined in a dynamic-link library (DLL) or assembly that is not directly referenced in your project. The [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler requires a reference to avoid ambiguity in case the class is defined in more than one DLL or assembly.  
  
 **Error ID:** BC30007  
  
### To correct this error  
  
-   Include the name of the unreferenced DLL or assembly in your project references.  
  
## See Also  
 [NIB How to: Add or Remove References By Using the Add Reference Dialog Box](assetId:///3bd75d61-f00c-47c0-86a2-dd1f20e231c9)   
 [Project References](../vs140/managing-references-in-a-project.md)   
 [Troubleshooting Broken References](../vs140/troubleshooting-broken-references.md)