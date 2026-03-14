<template>
  <div class="bg-primary-600">
    <div class="relative isolate overflow-hidden pt-14">
      <NuxtImg src="/conference-table.png"
               alt="People sitting around a conference table"
               class="absolute inset-0 -z-10 size-full object-cover brightness-[0.3]" />

      <div class="absolute inset-0 bg-primary-600/40 -z-10"></div>

      <div class="mx-auto max-w-7xl px-6 lg:px-8">
        <div class="text-center flex flex-col items-center my-16 py-16">
          <!-- Logo -->
          <NuxtImg src="/logo.svg"
                   alt="True North Federal Solutions Logo"
                   width="200"
                   height="45"
                   class="mx-auto lg:mx-0 mb-6 bg-white rounded-full p-4" />

          <!-- Title -->
          <h1
              class="text-4xl tracking-tight font-bold text-white sm:text-5xl md:text-6xl">
            <span class="block font-light">Government Contracting Success</span>
            <span class="block text-white font-extrabold">Federal, State, and
              Local</span>
          </h1>

          <!-- Updated tagline -->
          <p
             class="mt-3 text-base text-primary-100 sm:mt-5 sm:text-lg sm:max-w-xl sm:mx-auto md:mt-5 md:text-xl lg:mx-0">
            We Know the Rules, So You Can Win the Work.
          </p>

          <!-- CTA Buttons -->
          <div
               class="mt-5 sm:mt-8 flex flex-col sm:flex-row items-center justify-center gap-3">
            <UButton variant="solid"
                     size="lg"
                     icon="i-heroicons-calendar-days"
                     to="/contact"
                     class="flex w-80 items-center justify-center px-8 py-3 text-lg font-semibold !bg-white/95 !text-secondary-950 shadow-medium ring-1 ring-white/30 transition-colors hover:!bg-secondary-200 hover:!text-secondary-950 active:!bg-secondary-300 focus-visible:outline-none focus-visible:ring-2 focus-visible:ring-white focus-visible:ring-offset-2 focus-visible:ring-offset-primary-700">
              Schedule Consultation
            </UButton>
            <UButton variant="solid"
                     size="lg"
                     icon="i-heroicons-book-open"
                     to="/resources"
                     class="flex w-80 items-center justify-center px-8 py-3 text-lg font-semibold !bg-white/95 !text-secondary-950 shadow-medium ring-1 ring-white/30 transition-colors hover:!bg-secondary-200 hover:!text-secondary-950 active:!bg-secondary-300 focus-visible:outline-none focus-visible:ring-2 focus-visible:ring-white focus-visible:ring-offset-2 focus-visible:ring-offset-primary-700">
              Explore Resources
            </UButton>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>

</script>