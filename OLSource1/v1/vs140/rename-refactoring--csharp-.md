---
title: "Rename Refactoring (C#)"
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
  - "vs.csharp.refactoring.rename"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "refactoring [C#], Rename"
  - "Rename refactoring [C#]"
ms.assetid: 268942fc-b142-4dfa-8d90-bedd548c2e4f
caps.latest.revision: 49
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Rename Refactoring (C#)
**Rename** is a refactoring feature in the Visual Studio integrated development environment (IDE) that provides an easy way to rename identifiers for code symbols such as fields, local variables, methods, namespaces, properties, and types. **Rename** can be used to change the names in comments and in strings and to change the declarations and calls of an identifier.  
  
> [!NOTE]
>  When using Source Control for Visual Studio, get the latest version of sources before you try to perform rename refactoring.  
  
 Rename refactoring is available from the following Visual Studio features:  
  
|Feature|Behavior of Refactoring in the IDE|  
|-------------|----------------------------------------|  
|Code Editor|In the Code Editor, rename refactoring is available when you position the cursor on certain types of code symbols. When the cursor is in this position, you can invoke the **Rename** command by typing the keyboard shortcut (CTRL + R, CTRL + R), or by selecting the **Rename** command from a smart tag, shortcut menu, or the **Refactor** menu.|  
|Class View|When you select an identifier in Class View, rename refactoring is available from the shortcut menu and **Refactor** menu.|  
|Object Browser|When you select an identifier in Object Browser, rename refactoring is only available from the **Refactor** menu.|  
|Property Grid of the Windows Forms Designer|In the **Property Grid** of the Windows Forms Designer, changing the name of a control will initiate a rename operation for that control. The **Rename** dialog box will not appear.|  
|Solution Explorer|In **Solution Explorer**, a **Rename** command is available on the shortcut menu. If the selected source file contains a class whose class name is the same as the file name, you can use this command to simultaneously rename the source file and execute rename refactoring.\<br />\<br /> For example, if you create a default Windows-based application and then rename Form1.cs to TestForm.cs, the source file name Form1.cs will change to TestForm.cs and the class Form1 and all references to that class will be renamed to TestForm. **Note:**  The **Undo** command (CTRL+Z) will only undo rename refactoring in the code and will not change the file name back to the original name. \<br />\<br /> If the selected source file does not contain a class whose name is the same as the file name, the **Rename** command in **Solution Explorer** will only rename the source file and will not execute rename refactoring.|  
  
## Rename Operations  
 When you execute **Rename**, the refactoring engine performs a rename operation specific for each code symbol, as described in the following table.  
  
|Code Symbol|Rename Operation|  
|-----------------|----------------------|  
|Field|Changes the declaration and usages of the field to the new name.|  
|Local variable|Changes the declaration and usages of the variable to the new name.|  
|Method|Changes the name of the method and all references to that method to the new name. **Note:**  When you rename an extension method, the rename operation propagates to all instances of the method that are in scope, regardless of whether the extension method is being used as a static method or an instance method. For more information, see [Extension Methods (C# Programming Guide)](../vs140/extension-methods--csharp-programming-guide-.md).|  
|Namespace|Changes the name of the namespace to the new name in the declaration, all <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statements, and fully qualified names. **Note:**  When renaming a namespace, [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] also updates the **Default Namespace** property on the **Application** page of the **Project Designer**. This property cannot be reset by selecting **Undo** from the **Edit** menu. To reset the **Default Namespace** property value, you must modify the property in the **Project Designer**. For more information, see [Application Page](../vs140/application-page--project-designer--csharp-.md).|  
|Property|Changes the declaration and usages of the property to the new name.|  
|Type|Changes all declarations and all usages of the type to the new name, including constructors and destructors. For partial types, the rename operation will propagate to all parts.|  
  
#### To rename an identifier  
  
1.  Create a console application named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and then replace <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> with the following example code.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Place the cursor on <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, either in the method declaration or the method call.  
  
3.  From the **Refactor** menu, select **Rename**. The **Rename** dialog box appears.  
  
     You can also right-click the cursor, point to **Refactor** on the context menu, and then click **Rename** to display the **Rename** dialog box.  
  
4.  In the **New Name** field, type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
5.  Select the **Search in Comments** check box.  
  
6.  Click **OK**.  
  
7.  In the **Preview Changes** dialog box, click **Apply**.  
  
#### To rename an identifier using smart tags  
  
1.  Create a console application named <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and then replace <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> with the following example code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
2.  In the declaration for <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, type or backspace over the method identifier. A smart tag prompt will appear below this identifier.  
  
    > [!NOTE]
    >  You can only invoke rename refactoring using smart tags at the declaration of an identifier.  
  
3.  Type the keyboard shortcut SHIFT+ALT+F10, and then press the DOWN ARROW to display the smart tag menu.  
  
     -or-  
  
     Move the mouse pointer over the smart tag prompt to display the smart tag. Then move the mouse pointer over the smart tag and click the DOWN ARROW to display the smart tag menu.  
  
4.  Select the **Rename '\<identifer1>' to '\<identifier2>'** menu item to invoke rename refactoring without a preview of the changes to your code. All references to **\<identifer1>** will automatically be updated to **\<identifier2>**.  
  
     -or-  
  
     Select the **Rename with preview** menu item to invoke rename refactoring with a preview of the changes to your code. The **Preview Changes** dialog box will appear.  
  
## Remarks  
  
## Renaming Implemented or Overridden Members  
 When you **Rename** a member that either implements/overrides or is implemented/overridden by members in other types, [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] displays a dialog box that says the rename operation will cause cascading updates. If you click **Continue**, the refactoring engine recursively finds and renames all members in base and derived types that have implements/overrides relationships with the member being renamed.  
  
 The following code example contains members with implements/overrides relationships.  
  
 [!code[CsUsingCsIDERefactor#1](../vs140/codesnippet/CSharp/rename-refactoring--csharp-_1.cs)]  
  
 In the previous example, renaming <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> also renames <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> because <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> implements <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Next, the refactor engine recursively sees that <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is implemented by <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and renames <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. The refactor engine does not rename <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, because <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> does not override <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. The refactoring engine stops here unless you have **Rename overloads** checked in the **Rename** dialog box.  
  
 If **Rename overloads** is checked, the refactor engine renames <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> because it overloads <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> because it is overridden by <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> because it is an overload of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  When you rename a member that was defined in a referenced assembly, a dialog box explains that renaming will cause build errors.  
  
## Renaming Properties of Anonymous Types  
 When you rename a property in anonymous types, the rename operation will propagate to properties in other anonymous types that have the same properties. The following examples illustrate this behavior.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In the preceding code, renaming <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> will change <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> in both statements because they have the same underlying anonymous type.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 In the preceding code, renaming <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> will only rename one instance of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> because <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> do not have the same properties.  
  
## See Also  
 [Refactoring](../vs140/refactoring--csharp-.md)   
 [Anonymous Types (C# Programming Guide)](../vs140/anonymous-types--csharp-programming-guide-.md)