---
title: "Validate your system during development"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-techdebt"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "layer diagrams"
ms.assetid: c9dafb47-7b1d-4c72-9432-d43be3db1799
caps.latest.revision: 41
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Validate your system during development
Visual Studio can help keep your software consistent with the users' requirements and with the architecture of your system.  
  
 To see which versions of Visual Studio support each of these features, see [Version support for architecture and modeling tools](../vs140/what-s-new-for-design-in-visual-studio.md#VersionSupport).  
  
## Key Tasks  
 Use the following tasks to validate your software.  
  
|**Tasks**|**Associated Topics**|  
|---------------|---------------------------|  
|**Make sure your model is consistent:**<br /><br /> Depending on the way your project uses and interprets models, it might be useful to disallow some combinations of elements. For example, you could restrict UML classes so that they always have [!INCLUDE[TLA2#tla_net](../vs140/includes/tla2sharptla_net_md.md)]-compliant names. You can define constraints like these in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] extensions.|-   [How to: Validate a UML Model](../vs140/validate-your-uml-model.md)<br />-   [How to: Use Validation Constraints with UML Models](../vs140/define-validation-constraints-for-uml-models.md)|  
|**Make sure your software meets the users' requirements**:<br /><br /> You can use requirements and architectural models to help you organize the tests of your system and its components. This practice helps ensure that you test the requirements that are important to the users and other stakeholders, and it helps you update the tests quickly when the requirements change.|-   [Developing Tests from a Model](../vs140/develop-tests-from-a-model.md)|  
|**Make sure that your software remains consistent with the intended design of your system:**<br /><br /> Layer diagrams describe the intended dependencies between the components of your application. During development, you can verify that the actual dependencies in the code conform to the intended design.|-   [How to: Create Layer Diagrams from Code](../vs140/create-layer-diagrams-from-your-code.md)<br />-   [How to: Validate Code Against Layer Diagrams](../vs140/validate-code-with-layer-diagrams.md)|  
  
## External Resources  
  
|**Category**|**Links**|  
|------------------|---------------|  
|**Videos**|![link to video](../vs140/media/playvideo.gif "PlayVideo") [Channel 9: Doug Seven: Code Understanding and System Design with Visual Studio 2010](http://go.microsoft.com/fwlink/?LinkId=216100)<br /><br /> ![link to video](../vs140/media/playvideo.gif "PlayVideo") [Channel 9: Architecting an Application using a Layer Diagram](http://go.microsoft.com/fwlink/?LinkID=201117)<br /><br /> ![link to video](../vs140/media/playvideo.gif "PlayVideo") [MSDN How Do I Series: How to Validate Code using Layer Diagrams](http://go.microsoft.com/fwlink/?LinkID=214405)|  
|**Forums**|-   [Visual Studio Visualization & Modeling Tools](http://go.microsoft.com/fwlink/?LinkId=184720)<br />-   [Visual Studio Visualization & Modeling SDK (DSL Tools)](http://go.microsoft.com/fwlink/?LinkId=184721)|  
|**Blogs**|-   [Visual Studio ALM + Team Foundation Server Blog](http://go.microsoft.com/fwlink/?LinkID=201340)|  
|**Technical Articles and Journals**|[MSDN Architecture Center](http://go.microsoft.com/fwlink/?LinkId=201343)|  
  
## See Also  
 [Testing the application](assetId:///796b7d6d-ad45-4772-9719-55eaf5490dac)   
 [Extending Models and Diagrams](../vs140/extend-uml-models-and-diagrams.md)   
 [Modeling User Requirements](../vs140/model-user-requirements.md)   
 [Modeling the Application](../vs140/analyze-and-model-your-architecture.md)