<script setup lang="ts">
import { RotateCw } from '@vben-core/icons';

interface Props {
  captcha?: string;
  class?: any;
  loading?: boolean;
  onCaptchaClick?: () => void;
  placeholder?: string;
}

const props = withDefaults(defineProps<Props>(), {
  captcha: '',
  loading: false,
  placeholder: '',
});

const modelValue = defineModel<string>('value', { default: '' });
</script>

<template>
  <div class="flex w-full items-center gap-2">
    <input
      v-model="modelValue"
      :class="[
        'flex h-10 w-full rounded-md border border-input bg-background px-3 py-2 text-sm ring-offset-background placeholder:text-muted-foreground/50 focus-visible:outline-none focus-visible:ring-1 focus-visible:ring-ring disabled:cursor-not-allowed disabled:opacity-50',
        props.class,
      ]"
      :placeholder="placeholder"
      autocomplete="off"
    />
    <div
      class="flex h-10 w-28 flex-shrink-0 cursor-pointer items-center justify-center overflow-hidden rounded-md border border-input"
      role="button"
      tabindex="0"
      @click="onCaptchaClick?.()"
      @keydown.enter="onCaptchaClick?.()"
    >
      <img
        v-if="captcha && !loading"
        :src="captcha"
        alt="captcha"
        class="h-full w-full object-cover"
      />
      <RotateCw
        v-else
        :class="{ 'animate-spin': loading }"
        class="size-4 text-muted-foreground"
      />
    </div>
  </div>
</template>
