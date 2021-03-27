﻿using Abp.Captcha.Slider.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Abp.Captcha.Slider
{
    /// <summary>
    /// 滑条验证应用服务实现
    /// </summary>
    public class SliderAppService : CaptchaAppService, ISliderAppService
    {
        private readonly ISilderManager _silderManager;

        public SliderAppService(ISilderManager verifyPictureManager)
        {
            _silderManager = verifyPictureManager;
        }

        /// <summary>
        /// 验证滑条数据是否有效
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<bool> VerificationAsync(ValidationModel input)
        {
            return await _silderManager.VerificationAsync(input);
        }
    }
}
