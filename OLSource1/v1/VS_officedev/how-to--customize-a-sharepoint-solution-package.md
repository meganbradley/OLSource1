---
title: "How to: Customize a SharePoint Solution Package"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "VS.SharePointTools.RAD.PackageDesignerAdvanced"
  - "VS.SharePointTools.RAD.PackageDesigner.Manifest"
  - "VS.SharePointTools.RAD.PackageDesignerProperties"
  - "VS.SharePointTools.RAD.PackageDesigner.SwitchView"
dev_langs: 
  - "VB"
  - "CSharp"
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, packages"
ms.assetid: fd365f8c-8a80-4ce8-8e28-c0eb609f12f3
caps.latest.revision: 20
ms.author: "kempb"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Customize a SharePoint Solution Package
  You can use the Package Designer to create and customize a package (.wsp). For example, you can add SharePoint project items and Features, specify if the Web server is reset when the solution is deployed, and set the deployment server type.  
  
## Opening the Package Designer  
  
#### To open the Package Designer  
  
-   In **Solution Explorer**, double-click **Package**, or choose **View Designer** on the shortcut menu for **Package**.  
  
## Viewing the Packaged Manifest File  
 You can use the Package Designer to modify and generate the packaged manifest file. Then, you can view the XML code for this file in Visual Studio.  
  
#### To view the XML source file  
  
1.  In the **Package Designer**, choose **Manifest**.  
  
#### To view the packaged manifest file by using Solution Explorer  
  
1.  In **Solution Explorer**, choose **Show All Files**.  
  
2.  Expand Package, expand Package.package, and then open the Package.Template.xml file.  
  
    > [!NOTE]  
    >  When you open the manifest XML file for the package template, the files are automatically validated, and you can ignore the warnings that appear in the Error List window.  
  
## Changing the Manifest Template  
 You can change the XML code for the packaged manifest file in the Visual Studio XML Editor or the Manifest Template pane. Any changes to the XML code are merged into the packaged manifest file for the package.  
  
#### To change the manifest template by using the XML Editor  
  
1.  In the **Package Designer**, choose the **Manifest** tab, expand the **Edit Options** node, and then choose the **Open in XML Editor** link.  
  
     Changes to the XML are merged into the packaged manifest file.  
  
#### To change the manifest template by using the Manifest Template pane  
  
1.  In the **Package Designer**, choose the **Manifest** tab, expand the **Edit Options** node, and then change the XML that appears in the Manifest Template pane.  
  
     Changes to the XML appear in the **Preview of Packaged Manifest** pane.  
  
## Overwriting the Packaged Manifest File  
 You can disable the Package Designer and create the manifest.xml file manually. The first time that you perform this procedure, the current settings in the Package Designer are saved to the package template XML file. Then, you can modify or overwrite the XML code.  
  
> [!NOTE]  
>  If you add or remove SharePoint project items and Features in the XML file while the Package Designer is disabled, these project items and Features aren't packaged.  
  
#### To overwrite packaged manifest file by disabling the designer  
  
1.  In the **Package Designer**, choose the **Manifest** tab.  
  
2.  .  
  
3.  Expand the **Edit Options** node, choose the **Overwrite generated XML and edit manifest in the XML editor** link, and then choose the **Yes** button.  
  
     The template is updated with the current packaged manifest file.  
  
## Enabling the Package Designer  
 You can re-enable the Package Designer to customize the manifest.xml file.  
  
#### To re-enable the designer  
  
1.  In the **Package Designer**, choose the **Discard manifest edits and re-enable the designer** link, and then choose the **Yes** button.  
  
     The template is refreshed with the original text, and any changes to the XML are lost.  
  
## See Also  
 [Packaging and Deploying SharePoint Solutions](../VS_officedev/packaging-and-deploying-sharepoint-solutions.md)  
  
  