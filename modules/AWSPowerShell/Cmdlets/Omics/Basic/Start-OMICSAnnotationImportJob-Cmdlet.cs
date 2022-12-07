/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.Omics;
using Amazon.Omics.Model;

namespace Amazon.PowerShell.Cmdlets.OMICS
{
    /// <summary>
    /// Starts an annotation import job.
    /// </summary>
    [Cmdlet("Start", "OMICSAnnotationImportJob", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the Amazon Omics StartAnnotationImportJob API operation.", Operation = new[] {"StartAnnotationImportJob"}, SelectReturnType = typeof(Amazon.Omics.Model.StartAnnotationImportJobResponse))]
    [AWSCmdletOutput("System.String or Amazon.Omics.Model.StartAnnotationImportJobResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.Omics.Model.StartAnnotationImportJobResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class StartOMICSAnnotationImportJobCmdlet : AmazonOmicsClientCmdlet, IExecutor
    {
        
        #region Parameter ReadOptions_Comment
        /// <summary>
        /// <para>
        /// <para>The file's comment character.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("FormatOptions_TsvOptions_ReadOptions_Comment")]
        public System.String ReadOptions_Comment { get; set; }
        #endregion
        
        #region Parameter DestinationName
        /// <summary>
        /// <para>
        /// <para>A destination annotation store for the job.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String DestinationName { get; set; }
        #endregion
        
        #region Parameter ReadOptions_Encoding
        /// <summary>
        /// <para>
        /// <para>The file's encoding.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("FormatOptions_TsvOptions_ReadOptions_Encoding")]
        public System.String ReadOptions_Encoding { get; set; }
        #endregion
        
        #region Parameter ReadOptions_Escape
        /// <summary>
        /// <para>
        /// <para>A character for escaping quotes in the file.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("FormatOptions_TsvOptions_ReadOptions_Escape")]
        public System.String ReadOptions_Escape { get; set; }
        #endregion
        
        #region Parameter ReadOptions_EscapeQuote
        /// <summary>
        /// <para>
        /// <para>Whether quotes need to be escaped in the file.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("FormatOptions_TsvOptions_ReadOptions_EscapeQuotes")]
        public System.Boolean? ReadOptions_EscapeQuote { get; set; }
        #endregion
        
        #region Parameter ReadOptions_Header
        /// <summary>
        /// <para>
        /// <para>Whether the file has a header row.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("FormatOptions_TsvOptions_ReadOptions_Header")]
        public System.Boolean? ReadOptions_Header { get; set; }
        #endregion
        
        #region Parameter VcfOptions_IgnoreFilterField
        /// <summary>
        /// <para>
        /// <para>The file's ignore filter field setting.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("FormatOptions_VcfOptions_IgnoreFilterField")]
        public System.Boolean? VcfOptions_IgnoreFilterField { get; set; }
        #endregion
        
        #region Parameter VcfOptions_IgnoreQualField
        /// <summary>
        /// <para>
        /// <para>The file's ignore qual field setting.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("FormatOptions_VcfOptions_IgnoreQualField")]
        public System.Boolean? VcfOptions_IgnoreQualField { get; set; }
        #endregion
        
        #region Parameter Item
        /// <summary>
        /// <para>
        /// <para>Items to import.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [Alias("Items")]
        public Amazon.Omics.Model.AnnotationImportItemSource[] Item { get; set; }
        #endregion
        
        #region Parameter ReadOptions_LineSep
        /// <summary>
        /// <para>
        /// <para>A line separator for the file.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("FormatOptions_TsvOptions_ReadOptions_LineSep")]
        public System.String ReadOptions_LineSep { get; set; }
        #endregion
        
        #region Parameter ReadOptions_Quote
        /// <summary>
        /// <para>
        /// <para>The file's quote character.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("FormatOptions_TsvOptions_ReadOptions_Quote")]
        public System.String ReadOptions_Quote { get; set; }
        #endregion
        
        #region Parameter ReadOptions_QuoteAll
        /// <summary>
        /// <para>
        /// <para>Whether all values need to be quoted, or just those that contain quotes.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("FormatOptions_TsvOptions_ReadOptions_QuoteAll")]
        public System.Boolean? ReadOptions_QuoteAll { get; set; }
        #endregion
        
        #region Parameter RoleArn
        /// <summary>
        /// <para>
        /// <para>A service role for the job.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String RoleArn { get; set; }
        #endregion
        
        #region Parameter RunLeftNormalization
        /// <summary>
        /// <para>
        /// <para>The job's left normalization setting.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? RunLeftNormalization { get; set; }
        #endregion
        
        #region Parameter ReadOptions_Sep
        /// <summary>
        /// <para>
        /// <para>The file's field separator.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("FormatOptions_TsvOptions_ReadOptions_Sep")]
        public System.String ReadOptions_Sep { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'JobId'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Omics.Model.StartAnnotationImportJobResponse).
        /// Specifying the name of a property of type Amazon.Omics.Model.StartAnnotationImportJobResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "JobId";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the DestinationName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^DestinationName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^DestinationName' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter Force
        /// <summary>
        /// This parameter overrides confirmation prompts to force 
        /// the cmdlet to continue its operation. This parameter should always
        /// be used with caution.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter Force { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.DestinationName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Start-OMICSAnnotationImportJob (StartAnnotationImportJob)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Omics.Model.StartAnnotationImportJobResponse, StartOMICSAnnotationImportJobCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.DestinationName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.DestinationName = this.DestinationName;
            #if MODULAR
            if (this.DestinationName == null && ParameterWasBound(nameof(this.DestinationName)))
            {
                WriteWarning("You are passing $null as a value for parameter DestinationName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.ReadOptions_Comment = this.ReadOptions_Comment;
            context.ReadOptions_Encoding = this.ReadOptions_Encoding;
            context.ReadOptions_Escape = this.ReadOptions_Escape;
            context.ReadOptions_EscapeQuote = this.ReadOptions_EscapeQuote;
            context.ReadOptions_Header = this.ReadOptions_Header;
            context.ReadOptions_LineSep = this.ReadOptions_LineSep;
            context.ReadOptions_Quote = this.ReadOptions_Quote;
            context.ReadOptions_QuoteAll = this.ReadOptions_QuoteAll;
            context.ReadOptions_Sep = this.ReadOptions_Sep;
            context.VcfOptions_IgnoreFilterField = this.VcfOptions_IgnoreFilterField;
            context.VcfOptions_IgnoreQualField = this.VcfOptions_IgnoreQualField;
            if (this.Item != null)
            {
                context.Item = new List<Amazon.Omics.Model.AnnotationImportItemSource>(this.Item);
            }
            #if MODULAR
            if (this.Item == null && ParameterWasBound(nameof(this.Item)))
            {
                WriteWarning("You are passing $null as a value for parameter Item which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.RoleArn = this.RoleArn;
            #if MODULAR
            if (this.RoleArn == null && ParameterWasBound(nameof(this.RoleArn)))
            {
                WriteWarning("You are passing $null as a value for parameter RoleArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.RunLeftNormalization = this.RunLeftNormalization;
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.Omics.Model.StartAnnotationImportJobRequest();
            
            if (cmdletContext.DestinationName != null)
            {
                request.DestinationName = cmdletContext.DestinationName;
            }
            
             // populate FormatOptions
            var requestFormatOptionsIsNull = true;
            request.FormatOptions = new Amazon.Omics.Model.FormatOptions();
            Amazon.Omics.Model.TsvOptions requestFormatOptions_formatOptions_TsvOptions = null;
            
             // populate TsvOptions
            var requestFormatOptions_formatOptions_TsvOptionsIsNull = true;
            requestFormatOptions_formatOptions_TsvOptions = new Amazon.Omics.Model.TsvOptions();
            Amazon.Omics.Model.ReadOptions requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions = null;
            
             // populate ReadOptions
            var requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptionsIsNull = true;
            requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions = new Amazon.Omics.Model.ReadOptions();
            System.String requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Comment = null;
            if (cmdletContext.ReadOptions_Comment != null)
            {
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Comment = cmdletContext.ReadOptions_Comment;
            }
            if (requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Comment != null)
            {
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions.Comment = requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Comment;
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptionsIsNull = false;
            }
            System.String requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Encoding = null;
            if (cmdletContext.ReadOptions_Encoding != null)
            {
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Encoding = cmdletContext.ReadOptions_Encoding;
            }
            if (requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Encoding != null)
            {
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions.Encoding = requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Encoding;
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptionsIsNull = false;
            }
            System.String requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Escape = null;
            if (cmdletContext.ReadOptions_Escape != null)
            {
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Escape = cmdletContext.ReadOptions_Escape;
            }
            if (requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Escape != null)
            {
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions.Escape = requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Escape;
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptionsIsNull = false;
            }
            System.Boolean? requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_EscapeQuote = null;
            if (cmdletContext.ReadOptions_EscapeQuote != null)
            {
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_EscapeQuote = cmdletContext.ReadOptions_EscapeQuote.Value;
            }
            if (requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_EscapeQuote != null)
            {
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions.EscapeQuotes = requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_EscapeQuote.Value;
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptionsIsNull = false;
            }
            System.Boolean? requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Header = null;
            if (cmdletContext.ReadOptions_Header != null)
            {
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Header = cmdletContext.ReadOptions_Header.Value;
            }
            if (requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Header != null)
            {
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions.Header = requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Header.Value;
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptionsIsNull = false;
            }
            System.String requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_LineSep = null;
            if (cmdletContext.ReadOptions_LineSep != null)
            {
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_LineSep = cmdletContext.ReadOptions_LineSep;
            }
            if (requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_LineSep != null)
            {
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions.LineSep = requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_LineSep;
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptionsIsNull = false;
            }
            System.String requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Quote = null;
            if (cmdletContext.ReadOptions_Quote != null)
            {
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Quote = cmdletContext.ReadOptions_Quote;
            }
            if (requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Quote != null)
            {
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions.Quote = requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Quote;
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptionsIsNull = false;
            }
            System.Boolean? requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_QuoteAll = null;
            if (cmdletContext.ReadOptions_QuoteAll != null)
            {
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_QuoteAll = cmdletContext.ReadOptions_QuoteAll.Value;
            }
            if (requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_QuoteAll != null)
            {
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions.QuoteAll = requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_QuoteAll.Value;
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptionsIsNull = false;
            }
            System.String requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Sep = null;
            if (cmdletContext.ReadOptions_Sep != null)
            {
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Sep = cmdletContext.ReadOptions_Sep;
            }
            if (requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Sep != null)
            {
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions.Sep = requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions_readOptions_Sep;
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptionsIsNull = false;
            }
             // determine if requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions should be set to null
            if (requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptionsIsNull)
            {
                requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions = null;
            }
            if (requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions != null)
            {
                requestFormatOptions_formatOptions_TsvOptions.ReadOptions = requestFormatOptions_formatOptions_TsvOptions_formatOptions_TsvOptions_ReadOptions;
                requestFormatOptions_formatOptions_TsvOptionsIsNull = false;
            }
             // determine if requestFormatOptions_formatOptions_TsvOptions should be set to null
            if (requestFormatOptions_formatOptions_TsvOptionsIsNull)
            {
                requestFormatOptions_formatOptions_TsvOptions = null;
            }
            if (requestFormatOptions_formatOptions_TsvOptions != null)
            {
                request.FormatOptions.TsvOptions = requestFormatOptions_formatOptions_TsvOptions;
                requestFormatOptionsIsNull = false;
            }
            Amazon.Omics.Model.VcfOptions requestFormatOptions_formatOptions_VcfOptions = null;
            
             // populate VcfOptions
            var requestFormatOptions_formatOptions_VcfOptionsIsNull = true;
            requestFormatOptions_formatOptions_VcfOptions = new Amazon.Omics.Model.VcfOptions();
            System.Boolean? requestFormatOptions_formatOptions_VcfOptions_vcfOptions_IgnoreFilterField = null;
            if (cmdletContext.VcfOptions_IgnoreFilterField != null)
            {
                requestFormatOptions_formatOptions_VcfOptions_vcfOptions_IgnoreFilterField = cmdletContext.VcfOptions_IgnoreFilterField.Value;
            }
            if (requestFormatOptions_formatOptions_VcfOptions_vcfOptions_IgnoreFilterField != null)
            {
                requestFormatOptions_formatOptions_VcfOptions.IgnoreFilterField = requestFormatOptions_formatOptions_VcfOptions_vcfOptions_IgnoreFilterField.Value;
                requestFormatOptions_formatOptions_VcfOptionsIsNull = false;
            }
            System.Boolean? requestFormatOptions_formatOptions_VcfOptions_vcfOptions_IgnoreQualField = null;
            if (cmdletContext.VcfOptions_IgnoreQualField != null)
            {
                requestFormatOptions_formatOptions_VcfOptions_vcfOptions_IgnoreQualField = cmdletContext.VcfOptions_IgnoreQualField.Value;
            }
            if (requestFormatOptions_formatOptions_VcfOptions_vcfOptions_IgnoreQualField != null)
            {
                requestFormatOptions_formatOptions_VcfOptions.IgnoreQualField = requestFormatOptions_formatOptions_VcfOptions_vcfOptions_IgnoreQualField.Value;
                requestFormatOptions_formatOptions_VcfOptionsIsNull = false;
            }
             // determine if requestFormatOptions_formatOptions_VcfOptions should be set to null
            if (requestFormatOptions_formatOptions_VcfOptionsIsNull)
            {
                requestFormatOptions_formatOptions_VcfOptions = null;
            }
            if (requestFormatOptions_formatOptions_VcfOptions != null)
            {
                request.FormatOptions.VcfOptions = requestFormatOptions_formatOptions_VcfOptions;
                requestFormatOptionsIsNull = false;
            }
             // determine if request.FormatOptions should be set to null
            if (requestFormatOptionsIsNull)
            {
                request.FormatOptions = null;
            }
            if (cmdletContext.Item != null)
            {
                request.Items = cmdletContext.Item;
            }
            if (cmdletContext.RoleArn != null)
            {
                request.RoleArn = cmdletContext.RoleArn;
            }
            if (cmdletContext.RunLeftNormalization != null)
            {
                request.RunLeftNormalization = cmdletContext.RunLeftNormalization.Value;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.Omics.Model.StartAnnotationImportJobResponse CallAWSServiceOperation(IAmazonOmics client, Amazon.Omics.Model.StartAnnotationImportJobRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Omics", "StartAnnotationImportJob");
            try
            {
                #if DESKTOP
                return client.StartAnnotationImportJob(request);
                #elif CORECLR
                return client.StartAnnotationImportJobAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public System.String DestinationName { get; set; }
            public System.String ReadOptions_Comment { get; set; }
            public System.String ReadOptions_Encoding { get; set; }
            public System.String ReadOptions_Escape { get; set; }
            public System.Boolean? ReadOptions_EscapeQuote { get; set; }
            public System.Boolean? ReadOptions_Header { get; set; }
            public System.String ReadOptions_LineSep { get; set; }
            public System.String ReadOptions_Quote { get; set; }
            public System.Boolean? ReadOptions_QuoteAll { get; set; }
            public System.String ReadOptions_Sep { get; set; }
            public System.Boolean? VcfOptions_IgnoreFilterField { get; set; }
            public System.Boolean? VcfOptions_IgnoreQualField { get; set; }
            public List<Amazon.Omics.Model.AnnotationImportItemSource> Item { get; set; }
            public System.String RoleArn { get; set; }
            public System.Boolean? RunLeftNormalization { get; set; }
            public System.Func<Amazon.Omics.Model.StartAnnotationImportJobResponse, StartOMICSAnnotationImportJobCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.JobId;
        }
        
    }
}