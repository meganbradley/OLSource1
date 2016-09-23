---
title: "My.Resources Object"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - My.Resources
  - My.Resources.MyResources.ResourceManager
  - My.Resources.MyResources.Culture
dev_langs: 
  - VB
helpviewer_keywords: 
  - My.Resources object
ms.assetid: 34c3f2dc-7b87-432c-9d5f-17ea666bb266
caps.latest.revision: 26
translation.priority.ht: 
  - de-de
  - ja-jp
---
# My.Resources Object
Provides properties and classes for accessing the application's resources.  
  
## Remarks  
 The `My.Resources` object provides access to the application's resources and lets you dynamically retrieve resources for your application. For more information, see [Managing Application Resources](../vs140/managing-application-resources--.net-.md).  
  
 The `My.Resources` object exposes only global resources. It does not provide access to resource files associated with forms. You must access the form resources from the form. For more information, see [Walkthrough: Localizing Windows Forms](assetId:///9a96220d-a19b-4de0-9f48-01e5d82679e5).  
  
 You can access the application's culture-specific resource files from the `My.Resources` object. By default, the `My.Resources` object looks up resources from the resource file that matches the culture in the <xref:Microsoft.VisualBasic.ApplicationServices.ApplicationBase.UICulture?qualifyHint=False> property. However, you can override this behavior and specify a particular culture to use for the resources. For more information, see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890).  
  
## Properties  
 The properties of the `My.Resources` object provide read-only access to your application's resources. To add or remove resources, use the **Project Designer**. For more information, see [How to: Add or Remove Resources](assetId:///7b77bc06-3952-4799-b029-def3f8f7f88d). You can access resources added through the **Project Designer** by using `My.Resources.``resourceName`.  
  
 You can also add or remove resource files by selecting your project in **Solution Explorer** and clicking **Add New Item** or **Add Existing Item** from the **Project** menu. You can access resources added in this manner by using `My.Resources.``resourceFileName`.`resourceName`.  
  
 Each resource has a name, category, and value, and these resource settings determine how the property to access the resource appears in the `My.Resources` object. For resources added in the **Project Designer**:  
  
-   The name determines the name of the property,  
  
-   The resource data is the value of the property,  
  
-   The category determines the type of the property:  
  
|||  
|-|-|  
|Category|Property data type|  
|**Strings**|[String](../vs140/string-data-type--visual-basic-.md)|  
|**Images**|<xref:System.Drawing.Bitmap?qualifyHint=False>|  
|**Icons**|<xref:System.Drawing.Icon?qualifyHint=False>|  
|**Audio**|<xref:System.IO.UnmanagedMemoryStream?qualifyHint=False><br /><br /> The <xref:System.IO.UnmanagedMemoryStream?qualifyHint=False> class derives from the <xref:System.IO.Stream?qualifyHint=False> class, so it can be used with methods that take streams, such as the <xref:Microsoft.VisualBasic.Devices.Audio.Play?qualifyHint=False> method.|  
|**Files**|-   [String](../vs140/string-data-type--visual-basic-.md) for text files.<br />-   <xref:System.Drawing.Bitmap?qualifyHint=False> for image files.<br />-   <xref:System.Drawing.Icon?qualifyHint=False> for icon files.<br />-   <xref:System.IO.UnmanagedMemoryStream?qualifyHint=False> for sound files.|  
|**Other**|Determined by the information in the designer's **Type** column.|  
  
## Classes  
 The `My.Resources` object exposes each resource file as a class with shared properties. The class name is the same as the name of the resource file. As described in the previous section, the resources in a resource file are exposed as properties in the class.  
  
## Example  
 This example sets the title of a form to the string resource named `Form1Title` in the application resource file. For the example to work, the application must have a string named `Form1Title` in its resource file. For more information, see [How to: Add or Remove Resources](assetId:///7b77bc06-3952-4799-b029-def3f8f7f88d).  
  
 [!code[VbVbalrMyResources#1](../vs140/codesnippet/VisualBasic/my.resources-object_1.vb)]
  
  
## Example  
 This example sets the icon of the form to the icon named `Form1Icon` that is stored in the application's resource file. For the example to work, the application must have an icon named `Form1Icon` in its resource file.  
  
 [!code[VbVbalrMyResources#2](../vs140/codesnippet/VisualBasic/my.resources-object_2.vb)]
  
  
## Example  
 This example sets the background image of a form to the image resource named `Form1Background`, which is in the application resource file. For this example to work, the application must have an image resource named `Form1Background` in its resource file.  
  
 [!code[VbVbalrMyResources#3](../vs140/codesnippet/VisualBasic/my.resources-object_3.vb)]
  
  
## Example  
 This example plays the sound that is stored as an audio resource named `Form1Greeting` in the application's resource file. For the example to work, the application must have an audio resource named `Form1Greeting` in its resource file. The `My.Computer.Audio.Play` method is available only for Windows Forms applications.  
  
 [!code[VbVbalrMyResources#4](../vs140/codesnippet/VisualBasic/my.resources-object_4.vb)]
  
  
## Example  
 This example retrieves the French-culture version of a  string resource of the application. The resource is named `Message`. To change the culture that the `My.Resources` object uses, the example uses <xref:Microsoft.VisualBasic.ApplicationServices.ApplicationBase.ChangeUICulture?qualifyHint=False>.  
  
 For this example to work, the application must have a string named `Message` in its resource file, and the application should have the French-culture version of that resource file, Resources.fr-FR.resx. For more information, see [How to: Add or Remove Resources](assetId:///7b77bc06-3952-4799-b029-def3f8f7f88d). If the application does not have the French-culture version of the resource file, the `My.Resource` object retrieves the resource from the default-culture resource file.  
  
 [!code[VbVbalrMyResources#10](../vs140/codesnippet/VisualBasic/my.resources-object_5.vb)]
  
  
## See Also  
 [How to: Add or Remove Resources](assetId:///7b77bc06-3952-4799-b029-def3f8f7f88d)   
 [Managing Application Resources](../vs140/managing-application-resources--.net-.md)   
 [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890)   
 [Walkthrough: Localizing Windows Forms](assetId:///9a96220d-a19b-4de0-9f48-01e5d82679e5)