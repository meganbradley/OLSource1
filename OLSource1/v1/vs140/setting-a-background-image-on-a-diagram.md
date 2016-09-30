---
title: "Setting a Background Image on a Diagram"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: e334a24c-8521-4072-b50f-e59158dde145
caps.latest.revision: 6
---
# Setting a Background Image on a Diagram
In [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Visualization and Modeling SDK, you can set the background image for a generated designer by using custom code.  
  
## Setting the background image  
  
#### To set a background image for a generated designer  
  
1.  Copy the image file that you want to use as the diagram's background into the Dsl\Resources directory for the current project.  
  
2.  In **Solution Explorer**, right-click the Dsl\Resources folder, point to **Add**, and then click **Existing Item**.  
  
3.  In the **Add Existing Item** dialog box, browse to the Dsl\Resources folder.  
  
4.  In the **Files of type** list, click **Image Files**.  
  
5.  Click the image file that you copied to the directory, and then click **Add**.  
  
6.  Right-click Dsl, and click **Properties** to open the properties of the Dsl project.  
  
7.  On the **Resources** tab, click **This project does not contain a default resources file. Click here to create one.**  
  
8.  Add the image file to the resource file by dragging the picture from **Solution Explorer** into the resources window.  
  
9. Open the File menu, and click the option to save the project properties.  
  
10. Verify that the file Dsl\Properties\Resources.resx exists and has the file Resources.Designer.cs under it.  
  
11. If Resources.Designer.cs is missing, click the file Resources.resx in **Solution Explorer**.  
  
12. In the **Properties** window, set the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> property to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
13. In **Solution Explorer**, right-click the Dsl project, point to **Add**, and click **New Folder**.  
  
14. Name the folder **Custom**.  
  
15. Right-click the Custom folder, point to **Add**, and click **New Item**.  
  
16. In the **Add New Item** dialog box, in the **Templates** list, click **Code File**.  
  
17. In the **Name** box, type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and click **Add**.  
  
18. Copy the following code to the BackgroundImage.cs file, adjusting namespace, diagram class name, and image file resource name.  
  
     Replace "MyDiagramClass" with the name of the diagram partial class that is defined in Dsl\GeneratedCode\Diagrams.cs. You can also retrieve the correct namespace from the file Dsl\GeneratedCode\Diagrams.cs.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     For more information about customizing the model with program code, see [Navigating and Updating a Model](../vs140/navigating-and-updating-a-model-in-program-code.md).  
  
## See Also  
 [How to Display Shapes with Image and Text Fields](../vs140/defining-shapes-and-connectors.md)   
 [Customizing Text and Image Fields](../vs140/customizing-text-and-image-fields.md)   
 [Navigating and Updating a Model](../vs140/navigating-and-updating-a-model-in-program-code.md)   
 [Writing Code to Customize a Domain-Specific Language](../vs140/writing-code-to-customise-a-domain-specific-language.md)