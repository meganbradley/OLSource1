---
title: "Adding a Property (Visual C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "interfaces, adding properties"
  - "properties [C++], adding to interfaces"
ms.assetid: 37bd4db7-efd3-4faa-87ad-64902ed16a36
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Adding a Property (Visual C++)
You can use the [Add Property Wizard](../vs140/names--add-property-wizard.md) to add a method to an interface in your project.  
  
### To add a property to your object  
  
1.  In [Class View](assetId:///8d7430a9-3e33-454c-a9e1-a85e3d2db925), right-click the name of the interface to which you want to add the property.  
  
    > [!NOTE]
    >  You can also add properties to dispinterfaces, which, unless the project is attributed, are nested within the library node.  
  
2.  From the shortcut menu, click **Add**, and then click **Add Property**.  
  
3.  In the [Add Property Wizard](../vs140/names--add-property-wizard.md), provide the information to create the property.  
  
4.  Specify any interface definition language (IDL) settings for the property in the [IDL Attributes](../vs140/idl-attributes--add-property-wizard.md) page of the wizard.  
  
5.  Click **Finish** to add the property.  
  
 The **Get** and `Put` methods of the property are displayed as two icons in Class View, under the interface where it is defined. You can double-click either icon to view the property declaration in the .idl file.  
  
-   For ATL interfaces, the **Get** and **Put** functions are added to the .cpp file, and references to these functions are added to the .h file.  
  
-   For MFC dispinterfaces, if you select **Member variable** as the implementation type, a method and a variable are added to the class that implements it. If you select **Get/Set methods** as the implementation type, two methods are added to the class that implements it.  
  
## See Also  
 [Creating a COM Interface](../vs140/creating-a-com-interface--visual-c---.md)   
 [Editing a COM Interface](../vs140/editing-a-com-interface.md)   
 [The Component Object Model](http://msdn.microsoft.com/library/windows/desktop/ms694363)   
 [Interface Pointers and Interfaces](http://msdn.microsoft.com/library/windows/desktop/ms688484)