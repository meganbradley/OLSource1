---
title: Process Dialog Box (Analysis Services - Multidimensional Data)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c065248c-9001-4f0c-928f-9c59eccb618b
manager: mblythe
---
# Process Dialog Box (Analysis Services - Multidimensional Data)
Use the **Process** dialog box in [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)] and [!INCLUDE[ssManStudioFull](../../Topics/TopicNameContainA/includes/ssManStudioFull_md.md)] to process [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] objects. You can display the **Process** dialog box in [!INCLUDE[ssBIDevStudioFull](../../Topics/TopicNameContainA/includes/ssBIDevStudioFull_md.md)] by:  
  
-   Right-clicking an [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] project, cube, dimension, or mining structure in **Solution Explorer** and selecting **Process**.  
  
-   Selecting **Process** from the toolbar on every page of **Cube Designer**, every page of **Dimension Designer**, or the **Mining Structure** and **Mining Models** pages of **Data Mining Model Designer**.  
  
-   Right-clicking a mining model in the **Mining Models** page of **Data Mining Model Designer** and selecting **Process Mining Structure and All Models** or **Process Model**.  
  
 You can display the **Process** dialog box in **SQL Server Management Studio** by:  
  
-   Right-clicking an [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] database, cube, measure group, partition, dimension, mining structure, or mining model in **Object Explorer** and selecting **Process**.  
  
## Options  
 **Object list**  
 Select the [!INCLUDE[ssASnoversion](../../Topics/TopicNameContainA/includes/ssASnoversion_md.md)] objects to be processed and the processing options and settings to be applied. The grid contains the following columns:  
  
 **Object Name**  
 Displays the name of the object to be processed. The icon to the left of the name indicates the object type.  
  
 **Type**  
 Displays the type of the object to be processed.  
  
 **Process Options**  
 Select the type of processing to perform on the selected object. For more information about available processing options, see [Processing a multidimensional model (Analysis Services)](../../Topics/TopicNameContainA/Processing-a-multidimensional-model--Analysis-Services-.md).  
  
 **Settings**  
 Displays the **Configure** hyperlink when you choose **Process Incremental** in **Process Options** for cubes, measure groups, or partitions. Click **Configure** to launch the **Incremental Update** dialog box. For more information about the **Incremental Update** dialog box, see [Incremental Update Dialog Box (Analysis Services - Multidimensional Data)](../../Topics/TopicNameNotContainA/Incremental-Update-Dialog-Box--Analysis-Services---Multidimensional-Data-.md).  
  
 **Remove**  
 Click to remove the selected items from **Object list**.  
  
 **Impact Analysis**  
 Click to open the **Impact Analysis** dialog box and display the objects that will be affected by the processing task. For more information about the **Impact Analysis** dialog box, see [Impact Analysis Dialog Box (Analysis Services - Multidimensional Data)](../../Topics/TopicNameNotContainA/Impact-Analysis-Dialog-Box--Analysis-Services---Multidimensional-Data-.md).  
  
> [!NOTE]  
>  This option is disabled when the **Process affected objects** option is selected in the **Change Settings** dialog box.  
  
 **Change Settings**  
 Click to open the **Change Settings** dialog box and change the settings that govern processing of the selected objects, including batch processing settings, writeback settings, and dimension key error settings. For more information about the **Change Settings** dialog box, see [Change Settings Dialog Box (Analysis Services - Multidimensional Data)](../../Topics/TopicNameNotContainA/Change-Settings-Dialog-Box--Analysis-Services---Multidimensional-Data-.md).  
  
 **Run**  
 Click to process the objects.  
  
## See Also  
 [Analysis Services Designers and Dialog Boxes (Multidimensional Data)](../../Topics/TopicNameNotContainA/Analysis-Services-Designers-and-Dialog-Boxes--Multidimensional-Data-.md)   
 [Process Progress Dialog Box (Analysis Services - Multidimensional Data)](../../Topics/TopicNameNotContainA/Process-Progress-Dialog-Box--Analysis-Services---Multidimensional-Data-.md)