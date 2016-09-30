---
title: "Source code organization (C++ Templates)"
ms.custom: na
ms.date: "09/21/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 50569c5d-0219-4966-9bcf-a8689074ad1d
caps.latest.revision: 9
---
# Source code organization (C++ Templates)
When defining a class template, you must organize the source code in such a way that the member definitions are visible to the compiler when it needs them.   You have the choice of using the *inclusion model* or the *explicit instantiation* model. In the inclusion model, you include  the member definitions in every file that uses a template. This approach is simplest and provides maximum flexibility in terms of what concrete types can be used with your template. Its disadvantage is that it can increase compilation times. The impact can be significant if a project and/or the included files themselves are large. With the explicit instantiation approach, the template itself instantiates concrete classes or class members for specific types.  This approach can speed up compilation times, but it limits usage to only those classes that the template implementer has enabled ahead of time. In general, we recommend that you use the inclusion model  unless the compilation times become a problem.  
  
## Background  
 Templates are not like ordinary classes in the sense that the compiler does not generate object code for a template or any of its members. There is nothing to generate until the template is instantiated with concrete types.    When the compiler encounters a template instantiation such as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and no class with that signature exists yet, then  it generates a new class. It also attempts to generate code for any member functions that are used. If those definitions are in a file that is not #included, directly or indirectly, in the .cpp file that is being compiled, the compiler can't see them.  From the compiler's point of view, this isn't necessarily an error because the functions may be defined in another translation unit, in which case the linker will find them.  If the linker does not find that code, it raises an **unresolved external** error.  
  
## The inclusion model  
 The simplest and most common way to make template definitions visible throughout a translation unit,  is to put the definitions in the header file itself.  Any .cpp file that uses the template simply has to #include the header. This is the approach used in the Standard Library.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 With this approach,  the compiler has access to the complete template definition and can instantiate templates on-demand for any type. It is simple and relatively easy to maintain. However, the inclusion model does have a cost in terms of compilation times.   This cost can be significant in large programs, especially if the template header itself #includes other headers. Every .cpp file that #includes the header will get its own copy of the function templates and all the definitions. The linker will generally be able to sort things out so that you do not end up with multiple definitions for a function, but it takes time to do this work. In smaller programs that extra compilation time is probably not significant.  
  
## Explicit instantiation  
 If the inclusion model is not viable for your project, and you know definitively the set of types that will be used to instantiate a template, then you can separate out the template code into an .h and .cpp file, and in the .cpp file explicitly instantiate the templates. This will cause object code to be generated that the compiler will see when it encounters user instantiations.  
  
 You create an explicit instantiation by using the keyword template followed by the signature of the entity you want to instantiate. This can be a type or a member. If you explicitly instantiate a type, all members are instantiated.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In the previous example, the explicit instantiations are at the bottom of the .cpp file. A MyArray may be used only for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> types.  
  
> [!NOTE]
>  In C++11 the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword was deprecated in the context of template definitions. In practical terms this has little impact because most compilers never supported it.