<script setup lang="ts">
import type { Component } from 'vue';

import { computed } from 'vue';

import { IconDefault, IconifyIcon } from '@vben-core/icons';

const props = defineProps<{
  fallback?: boolean;
  icon?: Component | Function | string;
}>();

const isRemoteIcon = computed(() => {
  return (
    typeof props.icon === 'string' &&
    (props.icon.startsWith('http://') || props.icon.startsWith('https://'))
  );
});

const isComponent = computed(() => {
  const { icon } = props;
  return icon !== null && typeof icon === 'object' && !Array.isArray(icon);
});
</script>

<template>
  <component :is="icon as Component" v-if="isComponent" v-bind="$attrs" />
  <img v-else-if="isRemoteIcon" :src="icon as string" v-bind="$attrs" />
  <IconifyIcon v-else-if="icon" v-bind="$attrs" :icon="icon as string" />
  <IconDefault v-else-if="fallback" v-bind="$attrs" />
</template>
