---
title: "Visual Basic-Specific IntelliSense"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IntelliSense [Visual Basic]"
  - "IntelliSense [Visual Studio], Visual Basic"
ms.assetid: 4dec8753-05e5-4f74-b304-5f8c4ed8723b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Visual Basic-Specific IntelliSense
The Visual Basic source code editor offers the following IntelliSense features:  
  
-   Syntax tips  
  
     Syntax tips display the syntax of the statement that you are typing. This is useful for statements such as [Declare](../vs140/declare-statement.md).  
  
## Automatic Completion  
  
-   Completion on various keywords  
  
     For example, if you type <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and a space, IntelliSense will display a list of the defined labels in a drop-down menu. Other supported keywords include <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
-   Completion on <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
     When a statement will refer to a member of an enumeration, IntelliSense will display a list of the members of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. When a statement will refer to a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, IntelliSense will display a true-false drop-down menu.  
  
 Completion can be turned off by default by deselecting **Auto list members** from the **General** property page in the **Visual Basic** folder.  
  
 You can manually invoke completion by invoking List Members, Complete Word, or ALT+RIGHT ARROW. For more information, see [Using IntelliSense](../vs140/using-intellisense.md).  
  
## IntelliSense in Zone  
 IntelliSense in Zone assists Visual Basic developers who need to deploy applications through [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] and are constrained to partial trust settings. This feature:  
  
-   Enables you to choose the permissions the application will run with.  
  
-   Display APIs in the chosen Zone as available in List Members, and display APIs that require additional permissions as unavailable.  
  
 For more information, see [Code Access Security for ClickOnce Applications](../vs140/code-access-security-for-clickonce-applications.md).  
  
## See Also  
 [Using IntelliSense](../vs140/using-intellisense.md)