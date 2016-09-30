---
title: "Invalid assembly strong name or name not specified"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.tasklisterror.invalid_strong_name"
ms.assetid: cb02b69d-09a9-478f-914c-fbdc420e973d
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Invalid assembly strong name or name not specified
The project property in the project system's object model that lets you specify a keyname or key container for projects that will be built into assemblies with a strong name (signed assembly) was blank. The build will not succeed if this message is displayed.  
  
### To correct this error  
  
1.  Ensure that either a key container name or a key file is specified in code.  
  
## See Also  
 [Creating and Using Strong-Named Assemblies](assetId:///ffbf6d9e-4a88-4a8a-9645-4ce0ee1ee5f9)