---
title: "Packaging and Deploying Custom My Extensions (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "My namespace, customizing"
  - "My namespace"
  - "My namespace, extending"
ms.assetid: fd89c54b-0290-4c50-95a3-ff17d4487a21
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Packaging and Deploying Custom My Extensions (Visual Basic)
Visual Basic provides an easy way for you to deploy your custom <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> namespace extensions by using Visual Studio templates. If you are creating a project template for which your <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> extensions are an integral part of the new project type, you can just include your custom <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> extension code with the project when you export the template. For more information about exporting project templates, see [How to: Create Project Templates](../vs140/how-to--create-project-templates.md).  
  
 If your custom <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> extension is in a single code file, you can export the file as an item template that users can add to any type of Visual Basic project. You can then customize the item template to enable additional capabilities and behavior for your custom <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> extension in a Visual Basic project. Those capabilities include the following:  
  
-   Allowing users to manage your custom <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> extension from the **My Extensions** page of the Visual Basic Project Designer.  
  
-   Automatically adding your custom <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> extension when a reference to a specified assembly is added to a project.  
  
-   Hiding the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> extension item template in the **Add Item** dialog box so that it is not included in the list of project items.  
  
 This topic discusses how to package a custom <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> extension as a hidden item template that can be managed from the **My Extensions** page of the Visual Basic Project Designer. The custom <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> extension can also be added automatically when a reference to a specified assembly is added to a project.  
  
## Create a My Namespace Extension  
 The first step in creating a deployment package for a custom <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> extension is to create the extension as a single code file. For details and guidance about how to create a custom <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> extension, see [Extending the My Namespace in Visual Basic](../vs140/extending-the-my-namespace-in-visual-basic.md).  
  
## Export a My Namespace Extension as an Item Template  
 After you have a code file that includes your <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> namespace extension, you can export the code file as a Visual Studio item template. For instructions on how to export a file as a Visual Studio item template, see [How to: Create Item Templates](../vs140/how-to--create-item-templates.md).  
  
> [!NOTE]
>  If your <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> namespace extension has a dependency on a particular assembly, you can customize your item template to automatically install your <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> namespace extension when a reference to that assembly is added. As a result, you will want to exclude that assembly reference when you export the code file as a Visual Studio item template.  
  
## Customize the Item Template  
 You can enable your item template to be managed from the **My Extensions** page of the Visual Basic Project Designer. You can also enable the item template to be added automatically when a reference to a specified assembly is added to a project. To enable these customizations, you will add a new file, called the CustomData file, to your template, and then add a new element to the XML in your .vstemplate file.  
  
### Add the CustomData File  
 The CustomData file is a text file that has a file name extension of .CustomData (the file name can be set to any value meaningful to your template) and that contains XML. The XML in the CustomData file instructs Visual Basic to include your <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> extension when users use the **My Extensions** page of the Visual Basic Project Designer. You can optionally add the <<CodeContentPlaceHolder>19\</CodeContentPlaceHolder> attribute to your CustomData file XML. This instructs Visual Basic to automatically install your custom <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> extension when a reference to a particular assembly is added to the project. You can use any text editor or XML editor to create the CustomData file, and then add it to your item template's compressed folder (.zip file).  
  
 For example, the following XML shows the contents of a CustomData file that will add the template item to the My Extensions folder of a Visual Basic project when a reference to the Microsoft.VisualBasic.PowerPacks.Vs.dll assembly is added to the project.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The CustomData file contains a <<CodeContentPlaceHolder>21\</CodeContentPlaceHolder> element that has attributes as listed in the following table.  
  
|||  
|-|-|  
|Attribute|Description|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Required. A unique identifier for the extension. If the extension that has this ID has already been added to the project, the user will not be prompted to add it again.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Required. A version number for the item template.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Optional. An assembly name. When a reference to this assembly is added to the project, the user will be prompted to add the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> extension from this item template.|  
  
### Add the \<CustomDataSignature> Element to the .vstemplate File  
 To identify your Visual Studio item template as a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> namespace extension, you must also modify the .vstemplate file for your item template. You must add a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> element to the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> element must contain the text <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, as shown in the following example.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You cannot modify files in a compressed folder (.zip file) directly. You must copy the .vstemplate file from the compressed folder, modify it, and then replace the .vstemplate file in the compressed folder with your updated copy.  
  
 The following example shows the contents of a .vstemplate file that has the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> element added.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Install the Template  
 To install the template, you can copy the compressed folder (.zip file) to the Visual Basic item templates folder (for example, My Documents\Visual Studio 2008\Templates\Item Templates\Visual Basic). Alternatively, you can publish the template as a Visual Studio Installer (.vsi) file. For information about publishing your template as a Visual Studio Installer file, see [NIB: How to: Publish Project Templates](assetId:///b9087f58-64e9-4767-bf54-e3bf40d63b20).  
  
## See Also  
 [Extending the My Namespace in Visual Basic](../vs140/extending-the-my-namespace-in-visual-basic.md)   
 [Extending the Visual Basic Application Model](../vs140/extending-the-visual-basic-application-model.md)   
 [Customizing Which Objects are Available in My](../vs140/customizing-which-objects-are-available-in-my--visual-basic-.md)   
 [My Extensions Page, Project Designer (Visual Basic)](../vs140/my-extensions-page--project-designer--visual-basic-.md)