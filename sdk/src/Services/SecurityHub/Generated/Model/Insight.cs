/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains information about a Security Hub insight.
    /// </summary>
    public partial class Insight
    {
        private AwsSecurityFindingFilters _filters;
        private string _groupByAttribute;
        private string _insightArn;
        private string _name;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A collection of attributes that are applied to all active Security Hub-aggregated
        /// findings and that result in a subset of findings that are included in this insight.
        /// 
        /// </para>
        /// </summary>
        public AwsSecurityFindingFilters Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property GroupByAttribute. 
        /// <para>
        /// The attribute by which the insight's findings are grouped. This attribute is used
        /// as a findings aggregator for the purposes of viewing and managing multiple related
        /// findings under a single operand.
        /// </para>
        /// </summary>
        public string GroupByAttribute
        {
            get { return this._groupByAttribute; }
            set { this._groupByAttribute = value; }
        }

        // Check to see if GroupByAttribute property is set
        internal bool IsSetGroupByAttribute()
        {
            return this._groupByAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property InsightArn. 
        /// <para>
        /// The ARN of a Security Hub insight.
        /// </para>
        /// </summary>
        public string InsightArn
        {
            get { return this._insightArn; }
            set { this._insightArn = value; }
        }

        // Check to see if InsightArn property is set
        internal bool IsSetInsightArn()
        {
            return this._insightArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a Security Hub insight.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}