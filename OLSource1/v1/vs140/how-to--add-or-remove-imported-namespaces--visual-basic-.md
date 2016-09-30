---
title: "How to: Add or Remove Imported Namespaces (Visual Basic)"
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
  - "adding imported namespaces"
  - "removing imported namespaces"
  - "namespaces [Visual Studio], imported"
  - "imported namespaces [Visual Studio]"
  - "references [Visual Studio], imported namespaces"
ms.assetid: 44cebec3-0ea0-47c2-8406-4edeab6a997e
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Add or Remove Imported Namespaces (Visual Basic)
Importing a namespace allows you to use elements from that namespace in your code without fully qualifying the element. For example, if you want to access the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class, you can import the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> namespace and just refer to the element you need in code as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 Imported namespaces are managed on the **References** page of the **Project Designer**. The imports you specify in this dialog box are passed directly to the compiler (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) and apply to all files in your project. Use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement to use a namespace in a single source code file.  
  
### To add an imported namespace  
  
1.  In **Solution Explorer**, double-click the **My Project** node for the project.  
  
2.  In the **Project Designer**, click the **References** tab.  
  
3.  In the **Imported Namespaces** list, select the check box for the namespace that you wish to add.  
  
    > [!NOTE]
    >  In order to be imported, the namespace must be in a referenced component. If the namespace does not appear in the list, you will need to add a reference to the component that contains it. For more information, see [NIB How to: Add or Remove References By Using the Add Reference Dialog Box](assetId:///3bd75d61-f00c-47c0-86a2-dd1f20e231c9).  
  
### To remove an imported namespace  
  
1.  In **Solution Explorer**, double-click the **My Project** node for the project.  
  
2.  In the **Project Designer**, click the **References** tab.  
  
3.  In the **Imported Namespaces** list, clear the check box for the namespace that you wish to remove.  
  
## User Imports  
 User imports allow you to import a specific class within a namespace rather than the entire namespace. For example, your application might have an import for the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> namespace, but the only class within that namespace that you are interested in is the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class. You can define <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> as a user import, and then remove the import for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 If you later change you mind and decide that was really the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class that you needed, you could enter <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> as a user import and overwrite <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> using the update functionality.  
  
#### To add a user import  
  
1.  In **Solution Explorer**, double-click the **My Project** node for the project.  
  
2.  In the **Project Designer**, click the **References** tab.  
  
3.  In the text box below the **Imported Namespaces** list, enter the full name for the namespace you wish to import, including the root namespace.  
  
4.  Click the **Add user import** button to add the namespace to the **Imported Namespaces** list.  
  
    > [!NOTE]
    >  The **Add user import** button will be disabled if the namespace matches one already in the list; you cannot add an import twice.  
  
#### To update a user import  
  
1.  In **Solution Explorer**, double-click the **My Project** node for the project.  
  
2.  In the **Project Designer**, click the **References** tab.  
  
3.  In the **Imported Namespaces** list, select the namespace you wish to change.  
  
4.  In the text box below the **Imported Namespaces** list, enter the name for the new namespace.  
  
5.  Click the **Update user import** button to update the namespace in the **Imported Namespaces** list.  
  
## See Also  
 [Managing Project References](../vs140/managing-references-in-a-project.md)