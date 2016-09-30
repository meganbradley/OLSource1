---
title: "Analyze and model your architecture"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-techdebt"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
helpviewer_keywords: 
  - "Visual Studio Ultimate, exploring code"
  - "Visual Studio Ultimate, visualizing code"
  - "diagrams - modeling"
  - "Visual Studio ALM, modeling"
  - "application, design"
  - "architecture"
  - "code visualization"
  - "application design"
  - "applications, architecture"
  - "code exploration"
  - "Visual Studio ALM, exploring code"
  - "modeling"
  - "application architecture"
  - "application, modeling"
  - "applications, modeling"
  - "architecture [Visual Studio ALM], modeling"
  - "application modeling"
  - "Visual Studio Ultimate, modeling"
  - "architecture [Visual Studio Ultimate], modeling"
  - "application, architecture"
  - "Visual Studio ALM, visualizing code"
  - "applications, designing"
ms.assetid: c9f04cfa-72bd-419d-a952-616eed01472e
caps.latest.revision: 131
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Analyze and model your architecture
Make sure your app meets user requirements by using Visual Studio architecture and modeling tools to design and model your app. Understand existing program code more easily by using Visual Studio to visualize the code's structure, behavior, and relationships.  
  
 Create models at different levels of detail throughout the application lifecycle as part of your development process. Track requirements, tasks, test cases, bugs, and other work associated with your models by linking model elements to Team Foundation Server work items and your development plan. See [Scenario Overview: Change Your Design by Using Visualization and Modeling](../vs140/scenario--change-your-design-using-visualization-and-modeling.md).  
  
 To see which versions of Visual Studio support each feature, see [Version support for architecture and modeling tools](../vs140/what-s-new-for-design-in-visual-studio.md#VersionSupport)  
  
## To  
  
|||  
|-|-|  
|**Visualize code**:\<br />\<br /> -   See the code's organization and relationships by creating code maps. Visualize dependencies between assemblies, namespaces, classes, methods, and so on.\<br />-   See the class structure and members for a specific project by creating class diagrams from code.\<br />-   Find conflicts between your code and its design by creating layer diagrams to validate code.\<br />\<br /> **Note**: In this release of Visual Studio, the term *code map* is used in place of *dependency graph*. The term *graph* when used alone generally refers to a Directed Graph or DGML diagram (or document). Code maps are a specialized type of DGML diagram.|-   [Visualizing and Understanding Code](../vs140/visualize-code.md)\<br />-   [Working with Classes and Other Types](../vs140/working-with-classes-and-other-types--class-designer-.md)\<br />-   [Video: Understand your code dependencies through visualization (Channel 9)](http://go.microsoft.com/fwlink/?LinkID=252065)\<br />-   [Video: Visualize the impact of a change (Channel 9)](http://go.microsoft.com/fwlink/?LinkID=252068)|  
|**Describe and communicate user requirements**:\<br />\<br /> -   Clarify user stories, business rules, and other requirements and help ensure their consistency by drawing UML diagrams such as use case, activity, and class diagrams.|-   [Developing Models for Software Design](../vs140/create-models-for-your-app.md)\<br />-   [Modeling User Requirements](../vs140/model-user-requirements.md)\<br />-   [Video: Improve architecture through modeling (Channel 9)](http://go.microsoft.com/fwlink/?LinkID=252078)|  
|**Define the architecture**:\<br />\<br /> -   Model the large-scale structure of your software system and the design patterns by drawing UML component, class, and sequence diagrams.\<br />-   Define and enforce constraints on dependencies between the components of your code by creating layer diagrams.|-   [Developing Models for Software Design](../vs140/create-models-for-your-app.md)\<br />-   [Modeling the Architecture](../vs140/model-your-app-s-architecture.md)\<br />-   [Video: Improve architecture through modeling (Channel 9)](http://go.microsoft.com/fwlink/?LinkID=252078)\<br />-   [Video: Use layer diagrams to design and validate your architecture (Channel 9)](http://go.microsoft.com/fwlink/?LinkID=252073)|  
|**Validate your system with the requirements and intended design:**\<br />\<br /> -   Define acceptance tests or system tests based on the requirements models. This creates a strong relationship between the tests and your users' requirements and helps you update the system more easily when the requirements change.\<br />-   Validate code dependencies with layer diagrams that describe the intended architecture and prevent changes that might conflict with the design.|-   [Validating Your System During Development](../vs140/validate-your-system-during-development.md)\<br />-   [Video: Use layer diagrams to design and validate your architecture (Channel 9)](http://go.microsoft.com/fwlink/?LinkID=252073)|  
|**Share models, diagrams, and code maps using Team Foundation version control**:\<br />\<br /> -   Put code maps, modeling projects, UML diagrams, and layer diagrams under Team Foundation version control so you can share them.|When you have multiple users who work with these items under Team Foundation version control, use these guidelines to help you avoid version control issues:\<br />\<br /> -   [Managing models and diagrams under version control](../vs140/manage-models-and-diagrams-under-version-control.md)|  
|**Generate or configure parts of your application from UML or domain-specific languages**:\<br />\<br /> -   Make your design more responsive to requirements changes and easily variable across a product line.|-   [Driving Your Application from a Model](../vs140/generate-and-configure-your-app-from-models.md)|  
|**Customize models and diagrams**:\<br />\<br /> -   Adapt models to how your project uses them by defining additional properties for UML elements, validation constraints to make sure that your models conform to your business rules, and additional menu commands and toolbox items.\<br />-   Create your own domain-specific languages.|-   [Extending Models and Diagrams](../vs140/extend-uml-models-and-diagrams.md)\<br />-   [Visualization & Modeling SDK - Domain-Specific Languages](../vs140/modeling-sdk-for-visual-studio---domain-specific-languages.md)|  
|**Generate text using T4 templates**:\<br />\<br /> -   Use text blocks and control logic inside templates to generate text-based files.|-   [Code Generation and T4 Text Templates](../vs140/code-generation-and-t4-text-templates.md)|  
  
## Types of Models and Their Uses  
  
|**Model type and typical uses**|  
|-------------------------------------|  
|**Code maps**\<br />\<br /> Code maps help you see the organization and relationships in your code.\<br />\<br /> Typical uses:\<br />\<br /> -   Examine program code so you can better understand its structure and its dependencies, how to update it, and estimate the cost of proposed changes.\<br />\<br /> See:\<br />\<br /> -   [Map dependencies across your solutions](../vs140/map-dependencies-across-your-solutions.md)\<br />-   [Use code maps to debug your applications](../vs140/use-code-maps-to-debug-your-applications.md)\<br />-   [Find potential problems in code using code maps](../vs140/find-potential-problems-using-code-map-analyzers.md)|  
|**Layer diagram**\<br />\<br /> Layer diagrams let you define the structure of an application as a set of layers or blocks with explicit dependencies. You can run validation to discover conflicts between dependencies in the code and dependencies described on a layer diagram.\<br />\<br /> Typical uses:\<br />\<br /> -   Stabilize the structure of the application through numerous changes over its life.\<br />-   Discover unintentional dependency conflicts before checking in changes to the code.\<br />\<br /> See:\<br />\<br /> -   [How to: Create Layer Diagrams from Code](../vs140/create-layer-diagrams-from-your-code.md)\<br />-   [Layer Diagrams: Reference](../vs140/layer-diagrams--reference.md)\<br />-   [How to: Validate Code Against Layser Diagrams](../vs140/validate-code-with-layer-diagrams.md)|  
|**UML model**\<br />\<br /> A UML model includes several views, including class, component, use case, activity, and sequence diagrams. You can customize UML to suit your application domain. For example, you can attach tags, additional information, and constraints to the model elements. You can also define tools that operate on the models. See [Developing Models for Software Design](../vs140/create-models-for-your-app.md).\<br />\<br /> Typical uses:\<br />\<br /> -   Describe requirements and design. You can quickly apply UML to the development of any application. See [Using Models within the Development Process](../vs140/use-models-in-your-development-process.md).\<br />-   Generate or configure tests or parts of an application. Some work is required to customize the notation and develop the generation templates or configurable application. See [Generating Code](../vs140/generate-and-configure-your-app-from-models.md).\<br />-   For general description and for code generation or configuration in smaller projects.|  
|**Domain-specific language (DSL)**\<br />\<br /> A DSL is a notation that you design for a specific purpose. In Visual Studio, it is usually graphical.\<br />\<br /> Typical uses:\<br />\<br /> -   Generate or configure parts of the application. Work is required to develop the notation and tools. The result can be a better fit to your domain than a UML customization.\<br />-   For large projects or in product lines where the investment in developing the DSL and its tools is returned by its use in more than one project.\<br />\<br /> See:\<br />\<br /> -   [Visualization & Modeling SDK - Domain-Specific Languages](../vs140/modeling-sdk-for-visual-studio---domain-specific-languages.md)|  
  
## Where can I get more information?  
  
|||  
|-|-|  
|**Forums**|-   [Visual Studio Visualization & Modeling Tools](http://go.microsoft.com/fwlink/?LinkId=184720)\<br />-   [Visual Studio Visualization & Modeling SDK (DSL Tools)](http://go.microsoft.com/fwlink/?LinkId=184721)|  
  
## See Also  
 [What's New for Modeling Tools in Visual Studio](../vs140/what-s-new-for-design-in-visual-studio.md)   
 [DevOps and Application Lifecycle Management](assetId:///74a1f71d-7f23-4c71-8fd7-89ede614fab6)