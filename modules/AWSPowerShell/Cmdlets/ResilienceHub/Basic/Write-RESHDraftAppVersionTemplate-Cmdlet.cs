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
using Amazon.ResilienceHub;
using Amazon.ResilienceHub.Model;

namespace Amazon.PowerShell.Cmdlets.RESH
{
    /// <summary>
    /// Adds or updates the app template for an Resilience Hub application draft version.
    /// </summary>
    [Cmdlet("Write", "RESHDraftAppVersionTemplate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.ResilienceHub.Model.PutDraftAppVersionTemplateResponse")]
    [AWSCmdlet("Calls the AWS Resilience Hub PutDraftAppVersionTemplate API operation.", Operation = new[] {"PutDraftAppVersionTemplate"}, SelectReturnType = typeof(Amazon.ResilienceHub.Model.PutDraftAppVersionTemplateResponse))]
    [AWSCmdletOutput("Amazon.ResilienceHub.Model.PutDraftAppVersionTemplateResponse",
        "This cmdlet returns an Amazon.ResilienceHub.Model.PutDraftAppVersionTemplateResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class WriteRESHDraftAppVersionTemplateCmdlet : AmazonResilienceHubClientCmdlet, IExecutor
    {
        
        #region Parameter AppArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the AWS Resilience Hub application. The format for
        /// this ARN is: arn:<code>partition</code>:resiliencehub:<code>region</code>:<code>account</code>:app/<code>app-id</code>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>AWS General Reference</i> guide.</para>
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
        public System.String AppArn { get; set; }
        #endregion
        
        #region Parameter AppTemplateBody
        /// <summary>
        /// <para>
        /// <para>A JSON string that provides information about your application structure. To learn
        /// more about the <code>appTemplateBody</code> template, see the sample template provided
        /// in the <i>Examples</i> section.</para><para>The <code>appTemplateBody</code> JSON string has the following structure:</para><ul><li><para><b><code>resources</code></b></para><para>The list of logical resources that needs to be included in the Resilience Hub application.</para><para>Type: Array</para><note><para>Don't add the resources that you want to exclude.</para></note><para>Each <code>resources</code> array item includes the following fields:</para><ul><li><para><i><code>logicalResourceId</code></i></para><para>The logical identifier of the resource.</para><para>Type: Object</para><para>Each <code>logicalResourceId</code> object includes the following fields:</para><ul><li><para><code>identifier</code></para><para>The identifier of the resource.</para><para>Type: String</para></li><li><para><code>logicalStackName</code></para><para>The name of the CloudFormation stack this resource belongs to.</para><para>Type: String</para></li><li><para><code>resourceGroupName</code></para><para>The name of the resource group this resource belongs to.</para><para>Type: String</para></li><li><para><code>terraformSourceName</code></para><para>The name of the Terraform S3 state file this resource belongs to.</para><para>Type: String</para></li></ul></li><li><para><i><code>type</code></i></para><para>The type of resource.</para><para>Type: string</para></li><li><para><i><code>name</code></i></para><para>The name of the resource.</para><para>Type: String</para></li><li><para><code>additionalInfo</code></para><para>Additional configuration parameters for an AWS Resilience Hub application.</para><note><para>Currently, this parameter accepts a key-value mapping (in a string format) of only
        /// one failover region and one associated account.</para><para>Key: <code>"failover-regions"</code></para><para>Value: <code>"[{"region":"&lt;REGION&gt;", "accounts":[{"id":"&lt;ACCOUNT_ID&gt;"}]}]"</code></para></note></li></ul></li><li><para><b><code>appComponents</code></b></para><para>The list of Application Components that this resource belongs to. If an Application
        /// Component is not part of the AWS Resilience Hub application, it will be added.</para><para>Type: Array</para><para>Each <code>appComponents</code> array item includes the following fields:</para><ul><li><para><code>name</code></para><para>The name of the Application Component.</para><para>Type: String</para></li><li><para><code>type</code></para><para>The type of Application Component. For more information about the types of Application
        /// Component, see <a href="https://docs.aws.amazon.com/resilience-hub/latest/userguide/AppComponent.grouping.html">Grouping
        /// resources in an AppComponent</a>.</para><para>Type: String</para></li><li><para><code>resourceNames</code></para><para>The list of included resources that are assigned to the Application Component.</para><para>Type: Array of strings</para></li><li><para><code>additionalInfo</code></para><para>Additional configuration parameters for an AWS Resilience Hub application.</para><note><para>Currently, this parameter accepts a key-value mapping (in a string format) of only
        /// one failover region and one associated account.</para><para>Key: <code>"failover-regions"</code></para><para>Value: <code>"[{"region":"&lt;REGION&gt;", "accounts":[{"id":"&lt;ACCOUNT_ID&gt;"}]}]"</code></para></note></li></ul></li><li><para><b><code>excludedResources</code></b></para><para>The list of logical resource identifiers to be excluded from the application.</para><para>Type: Array</para><note><para>Don't add the resources that you want to include.</para></note><para>Each <code>excludedResources</code> array item includes the following fields:</para><ul><li><para><i><code>logicalResourceIds</code></i></para><para>The logical identifier of the resource.</para><para>Type: Object</para><note><para>You can configure only one of the following fields:</para><ul><li><para><code>logicalStackName</code></para></li><li><para><code>resourceGroupName</code></para></li><li><para><code>terraformSourceName</code></para></li></ul></note><para>Each <code>logicalResourceIds</code> object includes the following fields:</para><ul><li><para><code>identifier</code></para><para>The identifier of the resource.</para><para>Type: String</para></li><li><para><code>logicalStackName</code></para><para>The name of the CloudFormation stack this resource belongs to.</para><para>Type: String</para></li><li><para><code>resourceGroupName</code></para><para>The name of the resource group this resource belongs to.</para><para>Type: String</para></li><li><para><code>terraformSourceName</code></para><para>The name of the Terraform S3 state file this resource belongs to.</para><para>Type: String</para></li></ul></li></ul></li><li><para><b><code>version</code></b></para><para>The AWS Resilience Hub application version.</para></li><li><para><code>additionalInfo</code></para><para>Additional configuration parameters for an AWS Resilience Hub application.</para><note><para>Currently, this parameter accepts a key-value mapping (in a string format) of only
        /// one failover region and one associated account.</para><para>Key: <code>"failover-regions"</code></para><para>Value: <code>"[{"region":"&lt;REGION&gt;", "accounts":[{"id":"&lt;ACCOUNT_ID&gt;"}]}]"</code></para></note></li></ul>
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
        public System.String AppTemplateBody { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.ResilienceHub.Model.PutDraftAppVersionTemplateResponse).
        /// Specifying the name of a property of type Amazon.ResilienceHub.Model.PutDraftAppVersionTemplateResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the AppArn parameter.
        /// The -PassThru parameter is deprecated, use -Select '^AppArn' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^AppArn' instead. This parameter will be removed in a future version.")]
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
            this._AWSSignerType = "v4";
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.AppArn), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Write-RESHDraftAppVersionTemplate (PutDraftAppVersionTemplate)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.ResilienceHub.Model.PutDraftAppVersionTemplateResponse, WriteRESHDraftAppVersionTemplateCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.AppArn;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AppArn = this.AppArn;
            #if MODULAR
            if (this.AppArn == null && ParameterWasBound(nameof(this.AppArn)))
            {
                WriteWarning("You are passing $null as a value for parameter AppArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.AppTemplateBody = this.AppTemplateBody;
            #if MODULAR
            if (this.AppTemplateBody == null && ParameterWasBound(nameof(this.AppTemplateBody)))
            {
                WriteWarning("You are passing $null as a value for parameter AppTemplateBody which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            
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
            var request = new Amazon.ResilienceHub.Model.PutDraftAppVersionTemplateRequest();
            
            if (cmdletContext.AppArn != null)
            {
                request.AppArn = cmdletContext.AppArn;
            }
            if (cmdletContext.AppTemplateBody != null)
            {
                request.AppTemplateBody = cmdletContext.AppTemplateBody;
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
        
        private Amazon.ResilienceHub.Model.PutDraftAppVersionTemplateResponse CallAWSServiceOperation(IAmazonResilienceHub client, Amazon.ResilienceHub.Model.PutDraftAppVersionTemplateRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Resilience Hub", "PutDraftAppVersionTemplate");
            try
            {
                #if DESKTOP
                return client.PutDraftAppVersionTemplate(request);
                #elif CORECLR
                return client.PutDraftAppVersionTemplateAsync(request).GetAwaiter().GetResult();
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
            public System.String AppArn { get; set; }
            public System.String AppTemplateBody { get; set; }
            public System.Func<Amazon.ResilienceHub.Model.PutDraftAppVersionTemplateResponse, WriteRESHDraftAppVersionTemplateCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
