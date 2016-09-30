---
title: "Team Development with LightSwitch"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: dc09783e-7beb-439a-b509-1575b8c46d17
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Team Development with LightSwitch
If you're developing a LightSwitch application as part of a team, you can manage that development process more easily by using version control in Visual Studio. In earlier versions of LightSwitch, the nested project model made team development difficult. Starting with [!INCLUDE[vs_dev12](../vs140/includes/vs_dev12_md.md)], LightSwitch uses a flat project structure with separate model (.lsml) files for each entity and screen, so that you can integrate it seamlessly with version control systems.  
  
 You can choose Team Foundation Server on premises or in the cloud, or you can use any other version-control providers, such as Git, that Visual Studio supports. See [Use Team Foundation Version Control](http://msdn.microsoft.com/library/ms181237\(v=vs.120\).aspx) or [Use Visual Studio with Git](http://msdn.microsoft.com/library/hh850437\(v=vs.120\).aspx).  
  
## Best Practices  
  
-   Focus on developing the data model and its associated schema before you design screens. This practice minimizes merge conflicts that can occur when a screen targets an older version of an entity.  
  
-   If possible, divide the tasks so that each developer is responsible for a set of entities, screens, and queries. For example, if your application contains Customer, Order, and Product entities, you can reduce merge conflicts if a different developer works on each entity.  
  
-   After you check in the initial data model, keep subsequent changes as atomic as possible. Incremental and frequent check-ins are better than bulk and infrequent check-ins. This practice also helps you resolve manual merge conflicts more easily.  
  
-   When you check in, check in changes to all related model files at once rather than one file at a time. This practice keeps the overall model (combination of all .lsml entity and screen files) more consistent.  
  
-   Sync often, especially just before you check in so that you can resolve merge conflicts.  
  
-   If you must roll back any changes, make sure to roll back complete changesets rather than specific files. This practice keeps the underlying model more consistent and makes sure that your changes are atomic.  
  
## See Also  
 [Projects: The Container for Your LightSwitch Application](../vs140/projects--the-container-for-your-lightswitch-application.md)   
 [Use version control](http://msdn.microsoft.com/library/ms181368\(v=vs.120\).aspx)