/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require("gulp"),
    rimraf = require("rimraf"),
    concat = require("gulp-concat"),
    cssmin = require("gulp-cssmin"),
    uglify = require("gulp-uglify"),
    rename = require("gulp-rename");

var webroot = "./wwwroot/";

var paths = {
    js: webroot + "js/**/*.js",
    minJs: webroot + "js/**/*.min.js",
    css: webroot + "css/**/*.css",
    minCss: webroot + "css/**/*.min.css",
    jsSource: [
        webroot + "js/site.js",
        webroot + "js/script.js",
        webroot + "js/core.js",
        webroot + "js/html5shiv.js",
        webroot + "js/pointer-events.js"
    ],
    cssSource: [
        webroot + "css/site.css",
        webroot + "css/style.css"
    ]
};

gulp.task("clean:js", function (cb) {
    rimraf(paths.minJs, cb);
});


gulp.task("clean:css", function (cb) {
    rimraf(paths.minCss, cb);
});

gulp.task("clean", ["clean:js", "clean:css"]);


gulp.task("min:js", function () {
    return gulp.src(paths.jsSource)
        .pipe(rename({
            suffix: ".min"
        }))
        .pipe(uglify())
        .pipe(gulp.dest(webroot + "js/"));
});


gulp.task("min:css", function () {
    return gulp.src(paths.cssSource)
        .pipe(rename({
            suffix: ".min"
        }))
        .pipe(cssmin())
        .pipe(gulp.dest(webroot + "css/"));
});


gulp.task("min", ["min:js", "min:css"]);