/**
 * @zh_CN 登录页面 url 地址
 */
export const LOGIN_PATH = '/auth/login';

/**
 * Default tenant ID (default/master tenant)
 */
export const DEFAULT_TENANT_ID = '000000';

/**
 * System dictionary enum keys
 */
export enum DictEnum {
  SYS_DEVICE_TYPE = 'sys_device_type',
  SYS_GRANT_TYPE = 'sys_grant_type',
  SYS_NORMAL_DISABLE = 'sys_normal_disable',
  SYS_NOTICE_STATUS = 'sys_notice_status',
  SYS_NOTICE_TYPE = 'sys_notice_type',
  SYS_OPER_TYPE = 'sys_oper_type',
  SYS_USER_SEX = 'sys_user_sex',
  SYS_YES_NO = 'sys_yes_no',
  WF_BUSINESS_STATUS = 'wf_business_status',
  WF_TASK_STATUS = 'wf_task_status',
}

export interface LanguageOption {
  label: string;
  value: 'en-US' | 'zh-CN';
}

/**
 * Supported languages
 */
export const SUPPORT_LANGUAGES: LanguageOption[] = [
  {
    label: '简体中文',
    value: 'zh-CN',
  },
  {
    label: 'English',
    value: 'en-US',
  },
];
