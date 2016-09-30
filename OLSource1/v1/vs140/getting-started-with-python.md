---
title: "Getting Started with Python"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-python"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 33f4f6fb-0ae4-4234-9df2-531f2d3af17f
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Getting Started with Python
Microsoft provides Python Tools for Visual Studio (PTVS), a powerful plug-in Python IDE, for free and as an [open source project](https://github.com/Microsoft/ptvs).  
  
## Python the Language  
 Python has been a very popular programming language for a long time, used by many companies, scientists, casual and professional programmers (apps, cloud/web services, and web sites), and app scripters.  Python has many good properties:  
  
-   Reliable  
  
-   Generally useful for scripting quick programs, app scripting, desktop apps, web servers, web services, scientific computing  
  
-   Easy to learn and has a good design to encourage good coding (many universities use it for introductory programming courses)  
  
-   Supports a variety of styles of programming: imperative, functional, and object oriented  
  
-   Free open source and runs well on all major operating systems  
  
-   Many free, useful, and well-designed libraries  
  
-   Lots of documentation, samples, and help available on the internet  
  
 [Installing Python](http://python.org/download/)  
  
## PTVS  
 Microsoft provides Python Tools for Visual Studio (PTVS), a powerful plug-in Python IDE, for free and as an open source project ([PTVS](http://pytools.codeplex.com/)):  
  
 Some PTVS highlights:  
  
-   Supports multiple interpreters: various version of CPython, IronPython, and IPython  
  
-   Project system that implicitly picks up a directory structure of Python code, or that you can explicitly control so that it is clear what is app code, test code, web pages, JavaScript, build scripts, and so no  
  
-   Project templates for console programs, web projects, Azure projects, data science projects, and so on  
  
-   Azure SDK for Python (see below)  
  
-   Rich editing and code comprehension features: coloring, completion across all your code and libraries, signature help, class view, go to definition, find all references, refactoring, and so on  
  
-   Interactive Window (REPL) and IPython with data visualizations  
  
-   Support for IronPython and .NET/WPF  
  
-   Rich debugging without a project, attach to existing executable, mixed-mode debugging, remote debugging to Windows/Linux/Mac, and debugging within the Interactive Window  
  
-   Profiling tools  
  
-   Testing tools  
  
 [PTVS home page](https://www.visualstudio.com/en-us/explore/python-vs)  
  
 [Getting started and deep dive short videos](https://www.youtube.com/playlist?list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff)  
  
 [Installation and features demo (27 min)](https://www.youtube.com/watch?v=JNNAOypc6Ek)  
  
 [Wiki docs](http://pytools.codeplex.com/documentation)  
  
 [Installing PTVS](http://pytools.codeplex.com/wikipage?title=PTVS%20Installation)  
  
## Azure  
 The Azure SDK for Python makes it easy to consume and manage Microsoft Azure Services.  The Azure SDK for Python supports Windows, Mac, and Linux.  
  
 [Python Developer Center](http://azure.microsoft.com/en-us/develop/python/) has lots of help from installation to documentation with tutorials.  Some highlights follow:  
  
-   [Storage Blob](http://azure.microsoft.com/en-us/develop/python/how-to-guides/blob-service/)  
  
-   [Storage Queue](http://azure.microsoft.com/en-us/develop/python/how-to-guides/queue-service/)  
  
-   [Storage Table](http://azure.microsoft.com/en-us/develop/python/how-to-guides/table-service/)  
  
-   [Service Bus Queues](http://azure.microsoft.com/en-us/develop/python/how-to-guides/service-bus-queues/)  
  
-   [Service Bus Topics/Subscriptions](http://azure.microsoft.com/en-us/develop/python/how-to-guides/service-bus-topics/)  
  
-   [Service Management](http://azure.microsoft.com/en-us/develop/python/how-to-guides/service-management/)  
  
 [Azure SDK for Python open source](https://github.com/Azure/azure-sdk-for-python) has [unit tests](https://github.com/Azure/azure-sdk-for-python/tree/master/tests) that are also a good source of information on APIs.  
  
 **Installation:** [Python Package Index](https://pypi.python.org/pypi/azure) for using PIP, or for more information and [Azure executable installers](http://azure.microsoft.com/en-us/documentation/articles/python-how-to-install/)that optionally include Python.  
  
## Scientific Computing  
 In addition to all the Python data scientist libraries PTVS has support IPython and IPython Notebooks (which you can host in Azure).  You should get IPython and scientific computing libraries (matplotlib, scipy, numpy, etc.) from a distro (not PyPi), such as [UCI’s](http://www.lfd.uci.edu/~gohlke/pythonlibs/#scipy-stack).  For complete installation information and how to configure PTVS, see [Installation and Getting Started.](http://pytools.codeplex.com/wikipage?title=Using%20IPython%20with%20PTVS)  
  
## See Also  
 [Getting started setting up VS](../vs140/getting-started-with-ptvs--setting-up-visual-studio.md)   
 [Getting started start coding](../vs140/getting-started-with-ptvs--start-coding--projects-.md)   
 [Getting started editing code](../vs140/getting-started-with-ptvs--editing-code.md)   
 [Getting started debugging](../vs140/getting-started-with-ptvs--debugging.md)   
 [Getting started interactive](../vs140/getting-started-with-ptvs--interactive-python.md)   
 [Getting started web site](../vs140/getting-started-with-ptvs--building-a-website-in-azure.md)