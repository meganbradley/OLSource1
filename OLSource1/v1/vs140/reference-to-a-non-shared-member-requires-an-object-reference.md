---
title: "Reference to a non-shared member requires an object reference"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - bc30469
  - vbc30469
helpviewer_keywords: 
  - BC30469
ms.assetid: af503e8b-2e1f-4f91-a07f-b1ddd73dd4a6
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Reference to a non-shared member requires an object reference
You have referenced a non-shared member within your code and failed to supply an object reference. You cannot use the class name itself to qualify a member that is not shared. The instance must first be declared as an object variable and then referenced by the variable name.  
  
 **Error ID:** BC30469  
  
### To correct this error  
  
1.  Declare the instance as an object variable.  
  
2.  Reference the instance by the variable name.  
  
## See Also  
 [NOT IN BUILD: Understanding Classes](assetId:///cc2355a2-cb98-4353-9440-736585aec46c)   
 [NOT IN BUILD: Shared Members in Visual Basic](assetId:///dbc3783f-83a2-4225-995d-c2d6d025663d)   
 [Shared (Visual Basic)](../vs140/shared--visual-basic-.md)   
 [NOTINBUILD: Resolving a Reference When Multiple Variables Have the Same Name](assetId:///9601e39f-1911-44e1-ace5-3f6e090408b9)