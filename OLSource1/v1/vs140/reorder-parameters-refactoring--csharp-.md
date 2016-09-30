---
title: "Reorder Parameters Refactoring (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.csharp.refactoring.reorder"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "refactoring [C#], Reorder Parameters"
  - "Reorder Parameters refactoring [C#]"
ms.assetid: 4dabf21a-a9f0-41e9-b11b-55760cf2bd90
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Reorder Parameters Refactoring (C#)
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is a Visual C# refactoring operation that provides an easy way to change the order of the parameters for methods, indexers, and delegates. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> changes the declaration, and at any locations where the member is called, the parameters are rearranged to reflect the new order.  
  
 To perform the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operation, put the cursor on or next to a method, indexer, or delegate. When the cursor is in position, invoke the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operation by pressing the keyboard shortcut, or by clicking the command from the shortcut menu.  
  
> [!NOTE]
>  You cannot reorder the first parameter in an extension method.  
  
### To reorder parameters  
  
1.  Create a class library named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and then replace <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> with the following example code.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Place the cursor on <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, either in the method declaration or the method call.  
  
3.  On the **Refactor** menu, click **Reorder Parameters**.  
  
     The **Reorder Parameters** dialog box appears.  
  
4.  In the **Reorder Parameters** dialog box, select <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in the **Parameters** list, and then click the down button.  
  
     Alternatively, you can drag <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> after <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in the **Parameters** list.  
  
5.  In the **Reorder Parameters** dialog box, click **OK**.  
  
     If the **Preview reference changes** option is selected in the **Reorder Parameters** dialog box, the **Preview Changes - Reorder Parameters** dialog box will appear. It provides a preview of the changes in the parameter list for <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in both the signature and the method call.  
  
    1.  If the **Preview Changes - Reorder Parameters** dialog box appears, click **Apply**.  
  
         In this example, the method declaration and all the method call sites for <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> are updated.  
  
## Remarks  
 You can reorder parameters from a method declaration or a method call. Position the cursor on or next to the method or delegate declaration but not in the body.  
  
## See Also  
 [Refactoring](../vs140/refactoring--csharp-.md)