---
title: Features off by default (Analysis Services)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
  - analysis-services/multidimensional-tabular
  - analysis-services/data-mining
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a9529edf-337e-4fdd-9a13-99cfe96b4fa1
---
# Features off by default (Analysis Services)
  An instance of [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)] is designed to be secure by default. Therefore, features that might compromise security are disabled by default. The following features are installed in a disabled state and must specifically be enabled if you want to use them.  
  
## Feature List  
 To enable the following features, connect to [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)] using [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)]. Right\-click the instance name and choose **Facets**. Alternatively, you can enable these features through server properties, as described in the next section.  
  
-   Ad Hoc Data Mining \(OpenRowset\) Queries  
  
-   Linked Objects \(To\)  
  
-   Linked Objects \(From\)  
  
-   Listen Only On Local Connections  
  
-   User Defined Functions  
  
## Server properties  
 Additional features that are off by default can be enabled through server properties. Connect to [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)] using [!INCLUDE[ssManStudioFull](../../Token\Other/ssManStudioFull_md.md)]. Right\-click the instance name and choose **Properties**. Click **General**, and then click **Show Advanced** to display a larger property list.  
  
-   Ad Hoc Data Mining \(OpenRowset\) Queries  
  
-   Allow Session Mining Models \(Data Mining\)  
  
-   Linked Objects \(To\)  
  
-   Linked Objects \(From\)  
  
-   COM based user\-defined functions  
  
-   Flight Recorder Trace Definitions \(templates\).  
  
-   Query logging  
  
-   Listen Only On Local Connections  
  
-   Binary XML  
  
-   Compression  
  
-   Group affinity. See [Thread Pool Properties](../../Topics\TopicNameNotContainA/Thread-Pool-Properties.md) for details.  
  
  