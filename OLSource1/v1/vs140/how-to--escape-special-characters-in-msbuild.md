---
title: "How to: Escape Special Characters in MSBuild"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - special characters, escaping
  - characters, escapes
  - escape characters
  - MSBuild, escaping special characters
ms.assetid: 1aa3669c-1647-4960-b770-752e2532102f
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Escape Special Characters in MSBuild
Certain characters have special meaning in [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project files. Examples of the characters include semicolons (;) and asterisks (*). For a complete list of these special characters, see [MSBuild Special Characters](../vs140/msbuild-special-characters.md).  
  
 In order to use these special characters as literals in a project file, they must be specified by using the syntax %*xx*, where *xx* represents the ASCII hexadecimal value of the character.  
  
## MSBuild Special Characters  
 One example of where special characters are used is in the `Include` attribute of item lists. For example, the following item list declares two items: `MyFile.cs` and `MyClass.cs`.  
  
```  
<Compile Include="MyFile.cs;MyClass.cs"/>  
```  
  
 If you want to declare an item that contains a semicolon in the name, you must use the %*xx* syntax to escape the semicolon and prevent [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] from declaring two separate items. For example, the following item escapes the semicolon and declares one item named `MyFile.cs;MyClass.cs`.  
  
```  
<Compile Include="MyFile.cs%3BMyClass.cs"/>  
```  
  
#### To use an MSBuild special character as a literal character  
  
-   Use the notation %*xx* in place of the special character, where *xx* represents the hexadecimal value of the ASCII character. For example, to use an asterisk (*) as a literal character, use the value `%2A`.  
  
## See Also  
 [MSBuild Concepts](../vs140/msbuild-concepts.md)   
 [MSBuild](../vs140/msbuild.md)   
 [MSBuild Items](../vs140/msbuild-items.md)