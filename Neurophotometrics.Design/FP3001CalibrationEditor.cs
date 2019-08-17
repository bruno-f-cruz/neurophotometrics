﻿using Bonsai.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using Neurophotometrics.Design.Properties;
using System.Reflection;

namespace Neurophotometrics.Design
{
    class FP3001CalibrationEditor : WorkflowComponentEditor
    {
        public override bool EditComponent(ITypeDescriptorContext context, object component, IServiceProvider provider, IWin32Window owner)
        {
            if (provider != null)
            {
                var editorState = (IWorkflowEditorState)provider.GetService(typeof(IWorkflowEditorState));
                if (editorState != null)
                {
                    if (editorState.WorkflowRunning)
                    {
                        throw new InvalidOperationException(Resources.WorkflowRunning_Error);
                    }

                    var capture = (FP3001)component;
                    using (var editorForm = new FP3001CalibrationEditorForm(capture, provider))
                    {
                        try { editorForm.ShowDialog(owner); }
                        catch (TargetInvocationException ex)
                        {
                            throw ex.InnerException;
                        }
                    }
                }
            }

            return false;
        }
    }
}
