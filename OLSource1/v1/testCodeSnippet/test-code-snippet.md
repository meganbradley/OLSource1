---
title: "test code snippet"
ms.custom: na
ms.date: 08/25/2016
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9b1fe251-71c9-414e-97cd-a399322030d2
caps.latest.revision: 6
---
# test code snippet
## Welcome to CAPS Markdown Editor!

[!code[howto](../testCodeSnippet/codesnippet/embform.vb#emb_vb_usecheckbox)]


[!code[adomd.netserver](../testCodeSnippet/codesnippet/class1.cs#filterset)]


[!INCLUDE[applies_md](../testCodeSnippet/includes/applies_md.md)]

![5ff17e34-b578-4873-9d33-79500940d0bc](../testCodeSnippet/media/5ff17e34-b578-4873-9d33-79500940d0bc.gif)

```C#
  public static Set FilterSet(Set set, String filterExpression)
        {
            Expression expr = new Expression(filterExpression);

            SetBuilder resultSetBuilder = new SetBuilder();

            foreach (Tuple tuple in set)
            {
                if ((bool)(expr.Calculate(tuple)))
                {
                    resultSetBuilder.Add(tuple);
                }
            }

            return resultSetBuilder.ToSet();
        }
```

```vb
        Try
            ' Do something that may cause an exception.
            Throw New ApplicationException("An error has occured.")
        Catch ex As ApplicationException
            Dim str As String = "The action failed."
            Dim exTop As ApplicationException = New ApplicationException(str, ex)
            exTop.Source = Me.Text

            ' Show a message box if the global variable is true.
            If alwaysShow Then
                Dim box As ExceptionMessageBox = New ExceptionMessageBox(exTop)
                box.ShowCheckBox = True
                box.IsCheckBoxChecked = True
                box.CheckBoxText = "Always show this message"
                box.Show(Me)

                ' Set the global variable.
                alwaysShow = box.IsCheckBoxChecked
            End If
        End Try
```