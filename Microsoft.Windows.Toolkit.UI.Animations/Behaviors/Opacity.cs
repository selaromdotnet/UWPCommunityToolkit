﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using Microsoft.Windows.Toolkit.UI.Animations.Extensions;
using Windows.UI.Xaml;

namespace Microsoft.Windows.Toolkit.UI.Animations.Behaviors
{
    /// <summary>
    /// Performs an opacity animation using composition.
    /// </summary>
    /// <seealso>
    ///     <cref>Microsoft.Xaml.Interactivity.Behavior{Windows.UI.Xaml.UIElement}</cref>
    /// </seealso>
    public class Opacity : CompositionBehaviorBase
    {
        /// <summary>
        /// The Opacity value of the associated object
        /// </summary>
        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(double), typeof(Opacity), new PropertyMetadata(1d, PropertyChangedCallback));

        /// <summary>
        /// Gets or sets the Opacity.
        /// </summary>
        /// <value>
        /// The Opacity.
        /// </value>
        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        /// <summary>
        /// Starts the animation.
        /// </summary>
        public override void StartAnimation()
        {
            AssociatedObject.Opacity(Duration, Delay, (float)Value).StartAsync();
        }
    }
}